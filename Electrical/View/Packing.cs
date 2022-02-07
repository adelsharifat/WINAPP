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
using DevExpress.XtraBars;

namespace Electrical.View
{
    public partial class Packing : ViewTabWithCompany
    {
        private Dictionary<string, Model.TvpPackingItem> tvpPackingItems = new Dictionary<string, Model.TvpPackingItem>();
        private int? documentId = null;
        private DataRow packingDataRow = null;
        bool documentPosted = false;

        BarItem btnNewItem, btnSaveItem, btnPostItem;

        //Constructor fo view and editing packing mode
        public Packing()
        {
            InitializeComponent();
            BtnNewItem_ItemClick(null,null);
            ShowRefreshItem = false;
        }

        public Packing(int? documentId,DataRow dr)
        {
            InitializeComponent();
            this.documentId = documentId;
            this.packingDataRow = dr;
            this.documentPosted = Convert.ToBoolean(this.packingDataRow["Posted"]);

            ShowRefreshItem = false;
        }

        private void Packing_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitialLoadData();
                GoFormToCurrentState();
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
            btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);

            btnPostItem = e.RibbonPage.AddSignPostActionTool(this);

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
                if (Convert.ToBoolean(packingDataRow["Posted"])) throw new CMISException("Dear user,The packing document already posted!");

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
                if (cboCategory.EditValue == null) throw new CMISException("category field is required");
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
                GoFormToCurrentState();
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
                var categoryId = Convert.ToInt32(cboCategory.EditValue);
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




        #region InitialFormState
        private void GoFormToCurrentState()
        {
            if (FormMode == FormState.View)
            {
                grpPL.Enabled = false;
                grpPLHeader.Enabled = false;
                tsGrcPacking.Enabled = !documentPosted;

                btnSaveItem.Enabled  = !documentPosted;
                btnPostItem.Enabled  =  !documentPosted;

                //Load data
                if (this.documentId != null && this.packingDataRow != null)
                {
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

            if (FormMode == FormState.Edit)
            {
                
            }

            if (FormMode == FormState.Save)
            {
                ResetForm();
                grpPL.Enabled = true;
                grpPLHeader.Enabled = true;

                btnSaveItem.Enabled = true;
                btnPostItem.Enabled = btnPostItem.Group().Visible = false;

                tsGrcPacking.Enabled = true;

                btnDeleteItem.Enabled = true;
                btnEditItem.Enabled = true;

                grcPacking.DataSource = null;
                tvpPackingItems.Clear();
            }
        }
        #endregion






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

        private void cboCategory_EditValueChanged(object sender, EventArgs e)
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
                if (documentPosted) throw new CMISException("Dear user, The packing document is posted and you can not delete any packing item!");
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
                    if (documentPosted) throw new CMISException("Dear user, The packing document is posted and can not edit it!");
                    if (Msg.Confirm("Are you sure to edit selected item") == DialogResult.No) return;
                    grpPL.Enabled = true;
                    cboUnit.EditValue = Convert.ToInt32(dr["UnitId"]);
                    cboCategory.EditValue = dr["CategoryId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CategoryId"]);
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
                grpPL.Enabled = true;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
