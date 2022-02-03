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
using DMS.Enums;

namespace Electrical.View
{
    public partial class Packing : ViewTabWithCompany
    {
        private Dictionary<string, Model.TvpPackingItem> tvpPackingItems = new Dictionary<string, Model.TvpPackingItem>();
        private int? documentId = null;
        private DataRow packingDataRow = null;

        //Constructor fo view and editing packing mode
        public Packing()
        {
            InitializeComponent();
        }

        public Packing(int? documentId,DataRow dr)
        {
            InitializeComponent();
            this.documentId = documentId;
            this.packingDataRow = dr;
        }

        private void Packing_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                ShowRefreshItem = false;
                InitialLoadData();                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Packing_ViewLoaded(object sender, EventArgs e)
        {
            //Get document row in edit or view mode here
            if(this.documentId != null)
            {
                //Load data here
                LoadData();

            }
        }

        private void Packing_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void Packing_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            var btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);

            var btnPostItem = e.RibbonPage.AddSignPostActionTool(this);

            btnNewItem.ItemClick += BtnNewItem_ItemClick;
            btnSaveItem.ItemClick += BtnSaveItem_ItemClick;

            btnPostItem.ItemClick += BtnPostItem_ItemClick;

        }

        // Sign "PL" document action method
        private void BtnPostItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //check user only document is open or in edit mode documentId is nt null
                if (this.documentId == null) throw new CMISException("Document not found!");

                var signType = SignType.Post.ToString();
                var projectId = LoginInfo.ProjectId;
                var userId = LoginInfo.Id;
                var objectId = this.documentId;
                var nextRole = String.Empty;
                var machineName = CMISUtils.SecurityHelper.MachineName;
                var activeDirectoryName = CMISUtils.SecurityHelper.ActiveDirecotryName;
                var companyId = Convert.ToInt32(cmbCompany.EditValue);
                var result = DAL.Do.SignPLDocument(signType, projectId, userId, (int)objectId, nextRole, machineName, activeDirectoryName, companyId);

                if (result <= 0) throw new CMISException("Operation sign \"PL\" faild!");

                Msg.Show("Operationm sign \"PL\" succeded!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }



        // Helper for reset form
        private void ResetForm()
        {
            try
            {
                this.packingDataRow = null;
                this.documentId = null;
                cboUnit.SelectItem(0);
                cboItemCode.SelectItem(0);
                txtReport.Text = String.Empty;
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
        // Handle new for new and reset form item
        private void BtnNewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FormMode = FormState.Save;
                ResetForm();
                grpItemData.Enabled = true;
                grcPacking.DataSource = null;
                tvpPackingItems.Clear();
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
                // Check form mode
                if (FormMode == FormState.View) return;

                //Check Grid in empty
                if (grvPaking.RowCount <= 0) throw new CMISException("The grid is empty!");

                //Prompt for save or updating data
                var formOperationMode = this.documentId == null ? "save" : "update";
                if (Msg.Confirm($"Are you sure for {formOperationMode} data?") == DialogResult.No) return;

                //Mutation packing list
                // get form data for mutation db
                var projectId = LoginInfo.ProjectId;
                var companyId = Convert.ToInt32(cmbCompany.EditValue);
                var userId = LoginInfo.Id;
                var unitId = Convert.ToInt32(cboUnit.EditValue);
                var reportNo = txtReport.Text.Trim();
                var packingItems = tvpPackingItems.ToDataTable<string, Model.TvpPackingItem>();

                //Save data
                var result = DAL.Do.SavePacking(projectId, companyId, documentId, userId, reportNo, packingItems);
                if (result <= 0) throw new CMISException($"Operation {formOperationMode} faild!");
                Msg.Show($"Operation {formOperationMode} succeded!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
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
            try
            {
                if(this.documentId != null)
                {
                    tvpPackingItems.Clear();
                    grcPacking.DataSource = null;
                    grpItemData.Enabled = false;
                    FormMode = FormState.View;
                    // Get Packing Document
                    var projectId = Convert.ToInt32(this.packingDataRow["ProjectId"]);
                    var companyId = Convert.ToInt32(this.packingDataRow["CompanyId"]);
                    var packingDocument = DAL.Do.GetPackingDocuments(projectId, companyId, documentId) as DataRow;

                    if (packingDocument == null) throw new CMISException("Document not found");
                    txtReport.Text = packingDocument["ReportNo"].ToString();
                    cmbCompany.EditValue = Convert.ToInt32(packingDocument["CompanyId"]);

                    var packingItems = DAL.Do.GetPackingItemsByDocumentId(this.documentId);
                    if (packingItems.Rows.Count <= 0) throw new CMISException("Empty packing items");

                    
                    foreach (var item in packingItems.ToList<Model.TvpPackingItem>())
                    {
                        tvpPackingItems.Add(item.ItemCode, item);
                    }
                     
                    grcPacking.SetDataSource(() =>
                    {
                        return packingItems;
                    });
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
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
                Model.TvpPackingItem tvpPackingItem;

                var itemKey = cboItemCode.GetColumnValue("ItemCode").ToString();

                // Data will be update
                if (tvpPackingItems.ContainsKey(itemKey))
                {
                    var item = tvpPackingItems[itemKey];                    
                    item.ItemCodeId = Convert.ToInt32(cboItemCode.EditValue);
                    item.ItemCode = cboItemCode.Text;
                    item.UnitId = Convert.ToInt32(cboUnit.EditValue);
                    item.VendorId = Convert.ToInt32(cboVendor.EditValue);
                    item.TagNo = txtTag.Text.Trim();
                    item.CategoryId = Convert.ToInt32(cboCategory.EditValue);
                    item.SubCategoryId = Convert.ToInt32(cboSubCategory.EditValue);
                    item.Description = txtDescription.Text.Trim();
                    item.Size = txtSize.Text.Trim();
                    item.PackingNo = txtPackingNo.Text.Trim();
                    item.PLQty = Convert.ToDecimal(txtPlQty.Text.Trim());
                    item.QtyUnitId = Convert.ToInt32(cboQtyUnit.EditValue);

                }else//data will be insert
                {
                    tvpPackingItem = new Model.TvpPackingItem
                    {
                        ItemCodeId = Convert.ToInt32(cboItemCode.EditValue),
                        ItemCode = cboItemCode.Text,
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
                    tvpPackingItems.Add(itemKey, tvpPackingItem);
                }

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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Msg.Confirm("Are you sure to remove selected item") == DialogResult.No) return;
                if(grvPaking.GetFocusedDataRow() is DataRow dr)
                {
                    tvpPackingItems.Remove(dr["ItemCode"].ToString());
                    FillPackingListGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grcPacking_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if(grvPaking.RowCount>0)
                {
                    cmbCompany.Enabled = false;
                    txtReport.ReadOnly = true;
                    //cboUnit.Enabled = false;
                }
                else
                {
                    cmbCompany.Enabled = true;
                    txtReport.ReadOnly = false;
                    //cboUnit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvPaking.GetFocusedDataRow() is DataRow dr)
                {
                    if (Msg.Confirm("Are you sure to edit selected item") == DialogResult.No) return;
                    grpItemData.Enabled = true;
                    cboUnit.EditValue = Convert.ToInt32(dr["UnitId"]);
                    cboCategory.EditValue = dr["CategoryId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CategoryId"]);
                    cboSubCategory.EditValue = dr["SubCategoryId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SubCategoryId"]);
                    cboItemCode.EditValue = Convert.ToInt32(dr["ItemCodeId"]);
                    txtTag.Text = dr["TagNo"].ToString();
                    txtPackingNo.Text = dr["PackingNo"].ToString();
                    cboVendor.EditValue = Convert.ToInt32(dr["VendorId"]);
                    txtSize.Text = dr["Size"].ToString();
                    txtPlQty.Text = dr["PLQty"].ToString();
                    cboQtyUnit.EditValue = Convert.ToInt32(dr["QTYUnitId"]);
                    txtDescription.Text = dr["Description"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ResetForm();
                grpItemData.Enabled = true;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
