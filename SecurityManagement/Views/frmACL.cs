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
    public partial class frmACL : ViewForm
    {
        public frmACL()
        {
            InitializeComponent();
        }


        private int _id;
        private bool _isGroup;
        private int? _projectId;
        public frmACL(int id, bool isGroup,int? projectId = null)
        {
            InitializeComponent();
            try
            {
                _isGroup = isGroup;                
                if (!isGroup)
                {
                    ViewTitle = "User Permision";
                    _id = id;
                    var user = CommonDals.User.GetUserById("CM.FetchUserById", _id).Rows[0];
                    this.ViewTitle += $" - {user.ToString("UserName")} - [{user.ToString("FullName")}]";
                }
                else
                {
                    ViewTitle = "Group Permision";
                    _id = id;
                    _projectId = (int)projectId;
                    var group = CommonDals.User.GetGroupById(_id).Rows[0];                 
                    this.ViewTitle += $" - {group.ToString("Name")}";
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
            grvACL.ExpandAllGroups();
        }

        private void FillCboProject()
        {
            try
            {
                cboProject.Fill(CMISDAL.Common.CommonDals.Project.GetProjectList(), "Name", "Id");                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
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

            grcACL.SetDataSource(() =>
            {
                return ACLViewModelBindingList.ToList();
            });
        }


        private void GVACL_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(view.FocusedRowHandle) as ACLViewModel;
            if (view.FocusedColumn.FieldName == "Value" && row.Repository == null)
                e.Cancel = true;
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
                }).Where(x => x.Allow != null).ToList().ToDataTable<AclDBTableType>();

                var NotValidAcls = gridData.Select(x => CastAllow(x.ToInt("Allow")) == null && !String.IsNullOrEmpty(x.ToString("Value")) ? $"{x.ToString("Schema")}.{x.ToString("Name")}" : null).Where(x => x != null);
                if (NotValidAcls.Any()) throw new CMISException($"Can not set value items for inheritance acls!\nInvalid Acls:\n[ {string.Join(" - ", NotValidAcls)} ]");

                var aclItemAllowWithNoItem = gridData.Select(x => CastAllow(x.ToInt("Allow")) != null && String.IsNullOrEmpty(x.ToString("Value")) && !String.IsNullOrEmpty(x.ToString("ItemsDataProvider")) ? $"{x.ToString("Schema")}.{x.ToString("Name")}" : null).Where(x => x != null);
                if (aclItemAllowWithNoItem.Any()) throw new CMISException($"Can not set acl items allow without any items!\nInvalid Acls:\n[ {string.Join(" - ", aclItemAllowWithNoItem)} ]");

                var projectId = Convert.ToInt32(cboProject.EditValue);
                var result = DAL.New.SaveChangeACL(projectId, _id, aclData, _isGroup);

                if (result > 0)
                {
                    FillList();
                    Msg.Show("Save successfull!");
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

        private void frmACL_ViewLoaded(object sender, EventArgs e)
        {
            FillCboProject();            
        }

        private void cboProject_EditValueChanged(object sender, EventArgs e)
        {
            if (_isGroup && _projectId != null) cboProject.EditValue = _projectId;
            FillList();
        }

        private void grvACL_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            var view = sender as GridView;
            var row = view.GetRow(e.RowHandle) as ACLViewModel;

            if (e.Column.Name == "colValue" && row?.Repository != null)
            {                
                e.RepositoryItem = row.Repository;
            }
        }

        private void grvACL_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(view.FocusedRowHandle) as ACLViewModel;
            if (view.FocusedColumn.Name == "colValue" && row.Repository == null)
                e.Cancel = true;
        }

        private void grcACL_DataLoaded(object sender, EventArgs e)
        {
            try
            {
                grvACL.Columns["Id"].OptionsColumn.AllowEdit = false;
                grvACL.Columns["Schema"].OptionsColumn.AllowEdit = false;
                grvACL.Columns["Name"].OptionsColumn.AllowEdit = false;
                grvACL.Columns["Description"].OptionsColumn.AllowEdit = false;
                grvACL.Columns["Allow"].OptionsColumn.AllowEdit = true;
                grvACL.Columns["Value"].OptionsColumn.AllowEdit = true;
                grvACL.Columns["ItemsDataProvider"].OptionsColumn.AllowEdit = false;
                grvACL.Columns["Repository"].OptionsColumn.AllowEdit = false;

                grvACL.Columns["Schema"].Group();
                grcACL.HideColumns("Id,Schema,ItemsDataProvider,Repository");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvACL_GroupRowExpanded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            isExpanded = true;
        }

        private void grvACL_GroupRowCollapsed(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            isExpanded = false;
        }

        private void BtnResetAclList_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Are you sure to reset and restore acl list?") == DialogResult.No) return;
            FillList();
        }
    }
}
