using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using DevExpress.XtraBars;
using CMISUIHelper.Infrastructure.Helpers;
using Security;
using CMISDAL.Common;
using CMISUtils;
using CMISSecurity;
using Electrical.Data;
using CMISUtils.Extentions;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Enums;

namespace Electrical.View
{
    public partial class MIVList : ViewTabWithCompany
    {
        public MIVList()
        {
            InitializeComponent();
            ShowRefreshItem = true;
            ViewTitle = "MIV List";
            Grid = grcMIV;
        }

        private void MIVList_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitComboCompany();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MIVList_ViewLoaded(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MIVList_ViewRefresh(object sender, EventArgs e)
        {
            try
            {
                FillMIVGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Contract combo value change event
        private void cmbCompany_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillMIVGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MIVList_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var viewMenu = e.RibbonPage.AddViewFormActionTool(this);
            var editMenu = e.RibbonPage.AddEditFormActionTool(this);
            var deleteMenu = e.RibbonPage.AddDeleteFormActionTool(this);

            e.RibbonPage.AddGridTools(this);
            e.RibbonPage.AddExcelExportTool(this);

            //delegate vent for menus
            viewMenu.ItemClick += ViewMenu_ItemClick;
            editMenu.ItemClick += EditMenu_ItemClick;
            deleteMenu.ItemClick += DeleteMenu_ItemClick;

            //Set Permission
            viewMenu.Enabled =  ACL.ViewMIVDocument.AllowAcl(this);
            editMenu.Enabled =  ACL.EditMIVDocument.AllowAcl(this);
            deleteMenu.Enabled =  ACL.DeleteMIVDocument.AllowAcl(this);
        }

        #region Form Actions
        private void ViewMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (grvMIV.GetFocusedDataRow() is DataRow dr)
                {
                    CMISUI.UIHandler.ViewInTab<View.MIV>(this.OwnerForm, new object[] { dr, FormState.View });
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void EditMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (grvMIV.GetFocusedDataRow() is DataRow dr)
                {
                    var documentId = Convert.ToInt32(dr["Id"]);
                    var posted = Convert.ToBoolean(dr["Posted"]);
                    if (posted) throw new CMISException("The document posted and can not edit it!");
                        CMISUI.UIHandler.ViewInTab<View.MIV>(this.OwnerForm, new object[] { dr, FormState.Edit });
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void DeleteMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (grvMIV.GetFocusedDataRow() is DataRow dr)
                {
                    var documentId = dr.Id();
                    var posted = dr.Posted();
                    var deleted = dr.IsDelete();
                    if (deleted) throw new CMISException("The document already deleted!");
                    if (posted) throw new CMISException("The document posted and can not delete it!");
                    if (Msg.Confirm("Are you sure to delete the document?") == DialogResult.No) return;
                    var result = DAL.Do.DeleteMIVDocument(LoginInfo.ProjectId, LoginInfo.Id, documentId);
                    if (result <= 0) throw new CMISException("Operation delete miv document faild!");
                    Msg.Show("The document successfully deleted!");
                    FillMIVGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        #endregion

        #region Helpers
        //Fill contractor combo
        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
                this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      

        private void FillMIVGrid()
        {
            try
            {
                var contractId = cmbCompany.EditValue?.ToInt();
                if (contractId == null) return;
                var data = DAL.Do.GetMIVDocuments(null,LoginInfo.Id, (int)contractId, LoginInfo.ProjectId);
                grcMIV.SetDataSource(() =>
                {
                    return data;
                });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        
    }
}
