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
using CMISUIHelper.Infrastructure.Helpers;
using CMISDAL.Common;
using Security;
using CMISUtils;
using Electrical.Data;
using DevExpress.XtraEditors;
using CMISControls.Combo;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using DevExpress.XtraGrid.Views.Grid;

namespace Electrical.View
{
    public partial class Packing : ViewTabWithCompany
    {
        private Dictionary<string, Model.TvpPackingItem> tvpPackingItems = new Dictionary<string, Model.TvpPackingItem>();
        private int? documentId = null;

        public Packing()
        {
            InitializeComponent();
        }

        private void Packing_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitialLoadData();
                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Packing_ViewLoaded(object sender, EventArgs e)
        {

        }

        private void Packing_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void Packing_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            var btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);
            var btnEditItem = e.RibbonPage.AddEditFormActionTool(this);
            var btnDeleteItem = e.RibbonPage.AddDeleteFormActionTool(this);

            var btnPostItem = e.RibbonPage.AddSignPostActionTool(this);


            btnNewItem.ItemClick += BtnNewItem_ItemClick;
            btnSaveItem.ItemClick += BtnSaveItem_ItemClick;
            btnEditItem.ItemClick += BtnEditItem_ItemClick;
            btnDeleteItem.ItemClick += BtnDeleteItem_ItemClick;

        }

        // Helper for reset form
        private void ResetForm()
        {
            try
            {
                cboUnit.SelectItem(0);
                cboItemCode.SelectItem(0);
                txtTag.Text = String.Empty;
                cboCategory.SelectItem(0);
                cboSubCategory.SelectItem(0);
                txtSize.Text = String.Empty;
                txtPackingNo.Text = String.Empty;
                txtDescription.Text = String.Empty;
                cboVendor.SelectItem(0);
                txtPlQty.Text = String.Empty;
                cboQtyUnit.SelectItem(0);
                cmbCompany.SelectItem(0);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        // Helper for check validation form before save or update
        private void CheckValidationForm()
        {
            try
            {
                if (cboUnit.EditValue == null) throw new CMISException("Unit field is required!");
                if (cboItemCode.EditValue == null) throw new CMISException("ItemCode field is required");
                if (String.IsNullOrEmpty(txtTag.Text)) throw new CMISException("TagNo field is required");
                if (cboCategory.EditValue == null) throw new CMISException("Category field is required");
                if (cboSubCategory.EditValue == null) throw new CMISException("SubCategory field is required");
                if (cboSubCategory.EditValue == null) throw new CMISException("SubCategory field is required");
                if (String.IsNullOrEmpty(txtSize.Text)) throw new CMISException("Size field is required");
                if (String.IsNullOrEmpty(txtPackingNo.Text)) throw new CMISException("PackingNo field is required");
                if (String.IsNullOrEmpty(txtDescription.Text)) throw new CMISException("Description field is required");
                if (cboVendor.EditValue == null) throw new CMISException("Vendor field is required");
                if (String.IsNullOrEmpty(txtPlQty.Text)) throw new CMISException("P/L QTY field is required");
                if (cboQtyUnit.EditValue == null) throw new CMISException("QtyUnit field is required");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        // Handle new for edit item
        private void BtnNewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FormMode = FormState.Save;
                ResetForm();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Handle save packing
        private void BtnSaveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Prompt for save or updating data
                var formOperationMode = this.documentId == null ? "save" : "update";
                Msg.ConfirmOperation($"Are you sure for {formOperationMode} data?").Invoke();

                //Mutation packing list
                // get form data for mutation db
                var projectId = LoginInfo.ProjectId;
                var companyId = Convert.ToInt32(cmbCompany.EditValue);
                var userId = LoginInfo.Id;
                var unitId = Convert.ToInt32(cboUnit.EditValue);
                var reportNo = txtReport.Text.Trim();
                var packingItems = tvpPackingItems.ToDataTable<string, Model.TvpPackingItem>();

                //Save data
                var result = DAL.Do.SavePacking(projectId, companyId, documentId, unitId, userId, reportNo, packingItems);
                if (result <= 0) throw new CMISException($"Operation {formOperationMode} faild!");
                Msg.Show($"Operation {formOperationMode} succeded!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        // Handle edit packing before posted it
        private void BtnEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Handle delete a packing before posted it
        private void BtnDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Overrided
        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Company.FetchCompaniesCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Company");
                this.cmbCompany.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("Symbol");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        //Form helper functions
        private void InitialLoadData()
        {
            InitComboCompany();
            FillAreaUnitCombo();
            FillCategoryCombo();
            FillVendorCombo();
            FillPLQtyUnit();
            FillItemCodeCombo();
        }



        private void LoadData()
        {
            
        }

        //Fill category combo
        private void FillCategoryCombo()
        {
            try
            {
                var data = DAL.Do.GetCategoriesCombo(false);
                cboCategory.Fill(data, "Category", "Id").SelectItem(0).HideColumns("ParentId");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Fill subcategory combo
        private void FillSubCategoryCombo(int categoryId)
        {
            try
            {                
                var data = DAL.Do.GetSubCategoriesCombo(categoryId);
                cboSubCategory.Fill(data, "Category", "Id").SelectItem(0).HideColumns("ParentId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Fill packing list grid
        private void FillPackingListGrid()
        {
            try
            {
                grcPacking.SetDataSource(() =>
                {
                    return tvpPackingItems.ToDataTable<string, Model.TvpPackingItem>();
                });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Fill AreaUnit Combo
        private void FillAreaUnitCombo()
        {
            try
            {
                var data = CommonDals.Do.AreaUnit.FetchAreaUnitCombo(LoginInfo.ProjectId);
                cboUnit.Fill(data, "FullName", "Id").SelectItem(0);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Fill itemcode combo
        private void FillItemCodeCombo()
        {
            try
            {
                var categoryId = Convert.ToInt32(cboSubCategory.EditValue);
                var data = DAL.Do.GetItemCodesCombo(categoryId);
                cboItemCode.Fill(data, "ItemCode", "Id").SelectItem(0).HideColumns("WarehouseItemCodeId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Fill vendor combo
        private void FillVendorCombo()
        {
            try
            {
                var data = CommonDals.Do.Company.FetchCompaniesCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Vendor");
                cboVendor.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("Symbol");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Fill PLQtyUnit combo
        private void FillPLQtyUnit()
        {
            try
            {
                var data = DAL.Do.GetPLQtyUnit();
                cboQtyUnit.Fill(data, "Unit", "Id").SelectItem(0);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }






        // event edit value chage for subcategory combo filling
        private void cboCategory_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var categoryId = Convert.ToInt32(cboCategory.EditValue);
                FillSubCategoryCombo(categoryId);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {

                //Check Validation
                CheckValidationForm();

                // Create Model for making tvp
                Model.TvpPackingItem tvpPackingItem = new Model.TvpPackingItem
                {
                    ItemCodeId = Convert.ToInt32(cboItemCode.EditValue),
                    UnitId = Convert.ToInt32(cboUnit.EditValue),
                    VendorId = Convert.ToInt32(cboVendor.EditValue),
                    TagNo = txtTag.Text.Trim(),
                    CategoryId = Convert.ToInt32(cboCategory.EditValue),
                    SubCategoryId = Convert.ToInt32(cboSubCategory.EditValue),
                    Description = txtDescription.Text.Trim(),
                    Size = txtSize.Text.Trim(),
                    PackingNo = txtPackingNo.Text.Trim(),
                    PLQty = Convert.ToDecimal(txtPlQty.Text.Trim()),
                    QtyUnitId = Convert.ToInt32(cboQtyUnit.EditValue)
                };

                var itemKey = cboItemCode.GetColumnValue("ItemCode").ToString();

                if (tvpPackingItems.ContainsKey(itemKey)) throw new CMISException("This item code already exist in the list!");

                tvpPackingItems.Add(itemKey, tvpPackingItem);

                FillPackingListGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cboSubCategory_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillItemCodeCombo();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grvPaking_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var gv = sender as GridView;
                for (int i = 0; i < gv.RowCount; i++)
                {
                    gv.SetRowCellValue(i,"Id", - i+2);
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
