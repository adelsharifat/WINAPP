using CMISDAL.Common;
using CMISSecurity;
using CMISSecurity.Infrastructure.Enum;
using CMISSecurity.Model;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using CMISUtils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using SecurityManagement.Data;
using SecurityManagement.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManagement.Views
{
    public partial class frmACL : ViewBase
    {
        public frmACL()
        {
            InitializeComponent();
            ViewTitle = "User Permision";

        }

        private int _id;
        private bool _isGroup;
        public frmACL(int id, bool isGroup)
        {
            InitializeComponent();
            ViewTitle = "User Permision";
            try
            {
                _isGroup = isGroup;
                if (!isGroup)
                {
                    _id = id;
                    var user = CommonDals.User.GetUserById("CM.FetchUserById", _id).Rows[0];
                    this.Text += $" - {user.ToString("UserName")} - ( {user.ToString("FullName")} )";
                }
                else
                {
                    _id = id;
                    var group = CommonDals.User.GetGroupById(_id).Rows[0];
                    this.Text += $" - {group.ToString("Name")}";
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillList()
        {
            SetACLOnGridACL();
            this.isExpanded = true;
            grvACL.ExpandAllGroups();
        }

        private void SetACLOnGridACL()
        {
            List<ACLModel> PermissionDictionary = new List<ACLModel>();

            foreach (var item in new CMISPolicy().PermissionList)
            {
                PermissionDictionary.Add(item);
            }


            BindingList<ACLViewModel> ACLViewModelBindingList = new BindingList<ACLViewModel>();

            var aclData = DAL.New.FetchAcls(this._id, Convert.ToInt32(this.cboProject.GetColumnValue("Id")), _isGroup).AsEnumerable().Select(x => new DBUserACLViewModel
            {
                Id = x.ToInt("Id"),
                Name = x.ToString("Name"),
                Allow = x.To<bool>("Allow"),
                AclItemId = x.To<int>("AclItemId"),
                Value = x.To<int>("Value")
            }).ToList();


            foreach (var item in PermissionDictionary)
            {
                RepositoryItemCheckedComboBoxEdit repo = new RepositoryItemCheckedComboBoxEdit();
                ACLViewModel aclvm = new ACLViewModel();
                aclvm.Id = item.Id;
                aclvm.Schema = item.Schema;
                aclvm.Name = item.Name;
                aclvm.Description = item.Description;
                aclvm.Allow = AclCheckState.Inherit;
                aclvm.ItemsDataProvider = item.ItemsDataProvider != null ? item.ItemsDataProvider.AsEnumerable().Select(x =>
                    new CheckedListBoxItem
                    {
                        CheckState = CheckState.Unchecked,
                        Description = x[1].ToString(),
                        Tag = x[1],
                        Value = Convert.ToInt32(x[0])
                    }).ToArray() : null;
                aclvm.Repository = item.ItemsDataProvider != null ? repo : null;

                if (item.ItemsDataProvider != null)
                    aclvm.Repository.Items.AddRange(aclvm.ItemsDataProvider);

                ACLViewModelBindingList.Add(aclvm);
            }

            foreach (var item in ACLViewModelBindingList)
            {
                var aclName = $"{item.Schema}.{item.Name}";
                var row = aclData.FirstOrDefault(u => u.Name.ToLower() == aclName.ToLower());
                if (row != null)
                {
                    item.Id = row.Id;

                    if (row.Allow == null) item.Allow = AclCheckState.Inherit;
                    if (row.Allow == true) item.Allow = AclCheckState.Allow;
                    if (row.Allow == false) item.Allow = AclCheckState.Deny;

                    if (item.Repository != null)
                    {
                        var values = string.Join(",", aclData.Where(x => x.Name.ToLower() == aclName.ToLower()).Select(x => x.Value));
                        item.Value = values;
                    }
                }
            }

            grcACL.DataSource = ACLViewModelBindingList.ToList();
        }


        private void GVACL_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(view.FocusedRowHandle) as ACLViewModel;
            if (view.FocusedColumn.FieldName == "Value" && row.Repository == null)
                e.Cancel = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Are you sure to reset and restore acl list?") == DialogResult.Yes)
                FillList();
        }

        private void BtnSaveAclData_Click(object sender, EventArgs e)
        {
            try
            {
                var gridData = grvACL.GetDataTable().AsEnumerable();
                var aclData = gridData.Select(x => new AclDBTableType
                {
                    Id = x.ToInt("Id"),
                    Name = $"{x.ToString("Schema")}.{x.ToString("Name")}",
                    Allow = CastAllow(x.ToInt("Allow")),
                    Value = x["Value"].ToString()
                }).Where(x => !(x.Id == 0 && x.Allow == null)).ToList().ToDataTable<AclDBTableType>();

                var NotValidAcls = gridData.Select(x => CastAllow(x.ToInt("Allow")) == null && !String.IsNullOrEmpty(x.ToString("Value")) ? $"{x.ToString("Schema")}.{x.ToString("Name")}" : null).Where(x => x != null);

                if (NotValidAcls.Any()) throw new CMISException($"Can not set value items for inheritance acls!\nInvalid Acls:\n( {string.Join(" - ", NotValidAcls)} )");

                var result = DAL.New.SaveChangeACL(Convert.ToInt32(cboProject.GetColumnValue("Id")), _id, aclData, _isGroup);

                if (result > 0)
                {
                    FillList();
                    Msg.Info("Save successfull!");
                }

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private bool? CastAllow(int Allow)
        {
            bool? result = null;
            switch (Allow)
            {
                case 0:
                    result = null;
                    break;
                case 1:
                    result = true;
                    break;
                case -1:
                    result = false;
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        private bool isExpanded = false;
        private void BtnExpandCollaps_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                isExpanded = true;
                grvACL.ExpandAllGroups();
            }
            else
            {
                isExpanded = false;
                grvACL.CollapseAllGroups();
            }
        }

        private void frmACL_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage.AddGridTools(this);
                e.RibbonPage.AddExportTools(this);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
