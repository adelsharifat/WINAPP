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
using CMISDAL.Common;
using Security;
using CMISUtils;
using Electrical.Data;

namespace Electrical.View
{
    public partial class MIV : ViewTabWithCompany
    {

        private BarItem btnNew, btnSave, btnEdit, btnDelete;

        public MIV()
        {
            InitializeComponent();
        }

        private void MIV_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitComboCompany();
                FillCompaniesCombo();
                FillItemCodeCombo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MIV_ViewLoaded(object sender, EventArgs e)
        {

        }

        private void MIV_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void MIV_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                //Form action tools
                btnNew = e.RibbonPage.AddNewFormActionTool(this);
                btnSave = e.RibbonPage.AddSaveFormActionTool(this);
                btnEdit = e.RibbonPage.AddEditFormActionTool(this);
                btnDelete = e.RibbonPage.AddDeleteFormActionTool(this);

                //Grid tools
                e.RibbonPage.AddGridTools(this);

                //Export tools
                e.RibbonPage.AddExcelExportTool(this);

                btnNew.ItemClick += BtnNew_ItemClick;
                btnSave.ItemClick += BtnSave_ItemClick;
                btnEdit.ItemClick += BtnEdit_ItemClick;
                btnDelete.ItemClick += BtnDelete_ItemClick;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cboVendor_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReport_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }




        #region Override
        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
                this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Helpers
        private void FillCompaniesCombo()
        {
            try
            {
                var data = CommonDals.Do.Company.FetchCompaniesCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Company");
                this.cboCompanies.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("Symbol");
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        //Fill itemcode combo
        private void FillItemCodeCombo()
        {
            try
            {
                var data = DAL.Do.GetItemCodesCombo();
                cboItemCode.Fill(data, "ItemCode", "Id").SelectItem(0).HideColumns("WarehouseItemCodeId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        #endregion

    }
}
