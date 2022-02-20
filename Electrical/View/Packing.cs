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
using Electrical.Model;
using CMISUtils.Extentions;
using CMISSecurity;

namespace Electrical.View
{
    public partial class Packing : ViewTabWithCompany
    {
        private Dictionary<string, Model.TvpPackingItem> tvpPackingItems = new Dictionary<string, Model.TvpPackingItem>();
        private int? documentId = null;
        private DataRow packingDataRow = null;

        BarItem btnNew,btnSave,btnSaveAndPost,btnPost;

        //Constructor fo view and editing packing mode
        public Packing()
        {
            InitializeComponent();
            ShowRefreshItem = false;

            FormMode = FormState.Save;
        }

        public Packing(int? documentId,DataRow dr,FormState formState):this()
        {
            this.documentId = documentId;
            this.packingDataRow = dr;       
            FormMode = formState;            
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
            try
            {
                GoFormToCurrentState();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Packing_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void Packing_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            btnNew = e.RibbonPage.AddNewFormActionTool(this);
            btnSave = e.RibbonPage.AddSaveFormActionTool(this);
            btnSaveAndPost = e.RibbonPage.AddItem(this,"SavePost","Form",ElectricalResource.export_32x32);
            btnPost = e.RibbonPage.AddSignPostActionTool(this);

            btnNew.ItemClick += BtnNewItem_ItemClick;
            btnSave.ItemClick += BtnSaveItem_ItemClick;
            btnSaveAndPost.ItemClick += BtnSaveAndPost_ItemClick;
            btnPost.ItemClick += BtnPostItem_ItemClick;          
        }

        //Save and sign pl document
        private void BtnSaveAndPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Check form mode
                if (FormMode == FormState.View) return;

                //Check Grid in empty
                if (grvPaking.RowCount <= 0) return;

                if (Convert.ToBoolean(packingDataRow["Posted"])) throw new CMISException("Dear user,The packing document already posted!");
                if (Msg.Confirm("Are you sure to post document?") == DialogResult.No) return;

                var savePLDocument = new SavePLDocument
                {
                    DocumentId = this.documentId,
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    CompanyId = cmbCompany.EditValue.ToInt(),
                    UnitId = cboUnit.EditValue.ToInt(),
                    PackingItems = tvpPackingItems.ToDataTable()

                };

                var signPLDocument = new SignPLDocument
                {
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ObjectId = (int)this.documentId,
                    NextRole = String.Empty,
                    MachineName = SecurityHelper.MachineName,
                    ActiveDirectoryName = SecurityHelper.ActiveDirecotryName,
                    CompanyId = cmbCompany.EditValue.ToInt()
                };

                var result = DAL.Do.SaveAndSignPLDocument(savePLDocument,signPLDocument);

                if (result <= 0) throw new CMISException("Operation save and sign \"PL\" document faild!");

                Msg.Show("Operationm sign \"PL\" document succeded!");

                ResetForm();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        // Sign "PL" document action method
        private void BtnPostItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(packingDataRow["Posted"])) throw new CMISException("Dear user,The packing document already posted!");
                if (Msg.Confirm("Are you sure to post document?") == DialogResult.No) return;

                var signPLDocument = new SignPLDocument
                {
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ObjectId = (int)this.documentId,
                    NextRole = String.Empty,
                    MachineName = SecurityHelper.MachineName,
                    ActiveDirectoryName = SecurityHelper.ActiveDirecotryName,
                    CompanyId = cmbCompany.EditValue.ToInt()
                };

                var result = DAL.Do.SignPLDocument(signPLDocument);

                if (result <= 0) throw new CMISException("Operation sign \"PL\" faild!");

                Msg.Show("Operationm sign \"PL\" succeded!");

                ResetForm();
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
                if (cboTreeCategory.EditValue == null) throw new CMISException("category field is required");
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
                GoFormToCurrentState();
                
            }
            catch (Exception ex)
            {
                throw ex;
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
                if (grvPaking.RowCount <= 0) return;

                //Prompt for save or updating data
                var formOperationMode = this.documentId == null ? "save" : "update";
                if (Msg.Confirm($"Are you sure for {formOperationMode} data?") == DialogResult.No) return;

                //Mutation packing list
                // get form data for mutation db
                var savePLDocument = new SavePLDocument
                {
                    DocumentId = this.documentId,
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    CompanyId = cmbCompany.EditValue.ToInt(),
                    UnitId = cboUnit.EditValue.ToInt(),
                    PackingItems = tvpPackingItems.ToDataTable()

                };

                //Save data
                var result = DAL.Do.SavePLDocument(savePLDocument);
                if (result <= 0) throw new CMISException($"Operation {formOperationMode} faild!");
                ResetForm();
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
            FillCategoriesCombo();
            FillVendorCombo();
            FillPLQtyUnit();
            FillItemCodeCombo();
        }

        //Fill category combo
        private void FillCategoriesCombo()
        {
            try
            {
                var data = DAL.Do.GetCategoriesCombo();
                cboTreeCategory.Properties.DataSource = data;
                cboTreeCategory.Properties.DisplayMember = "Category";
                cboTreeCategory.Properties.KeyMember = "Id";
                cboTreeCategory.Properties.ValueMember = "Id";
                //cboTreeCategory.Properties.TreeList.PopulateColumns();
                cboTreeCategory.Properties.TreeList.Columns["Id"].Visible = false;
                cboTreeCategory.Properties.TreeList.Columns["ParentId"].Visible = false;
                cboTreeCategory.EditValue = 0;

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
                var categoryId = Convert.ToInt32(cboTreeCategory.EditValue);
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


        // Helper for reset form
        private void ResetForm()
        {
            try
            {
                FormMode = FormState.Save;
                GoFormToCurrentState();
                this.packingDataRow = null;
                this.documentId = null;
                cboUnit.SelectItem(0);
                cboItemCode.SelectItem(0);
                txtReport.Text = String.Empty;
                txtTag.Text = String.Empty;
                cboTreeCategory.EditValue = 0;
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

        #region InitialFormState
        private void GoFormToCurrentState()
        {
            try
            {
                //GetPermissions
                var canViewPLDocument = ACL.ViewPLDocument.AllowAcl(this);
                var canSavePLDocument = ACL.SavePLDocument.AllowAcl(this);
                var canEditPLDocument = ACL.EditPLDocument.AllowAcl(this);
                var canPostPLDocument = ACL.PostPLDocument.AllowAcl(this);

                if (FormMode == FormState.View)
                {
                    var posted = packingDataRow.Posted();
                    var deleted = packingDataRow.IsDelete();
                    grpPL.Enabled = false;
                    grpPLHeader.Enabled = false;
                    tsGrcPacking.Enabled = false;
                    btnSave.Enabled = btnSaveAndPost.Enabled = false;
                    btnSave.Visibility = btnSaveAndPost.Visibility = BarItemVisibility.Never;
                    btnPost.Enabled = btnPost.Group().Visible = canPostPLDocument && !deleted && !posted;

                    //Load data
                    if (this.documentId != null && this.packingDataRow != null)
                    {
                        var projectId = Convert.ToInt32(this.packingDataRow["ProjectId"]);
                        var companyId = Convert.ToInt32(this.packingDataRow["CompanyId"]);
                        var packingDocument = DAL.Do.GetPackingDocuments(projectId, LoginInfo.Id, companyId, documentId) as DataRow;

                        if (packingDocument == null) throw new CMISException("Document not found");
                        txtReport.Text = packingDocument["ReportNo"].ToString();
                        cmbCompany.EditValue = Convert.ToInt32(packingDocument["CompanyId"]);

                        var packingItems = DAL.Do.GetPackingItemsByDocumentId(this.documentId);
                        if (packingItems.Rows.Count > 0)
                        {
                            foreach (var item in packingItems.ToList<Model.TvpPackingItem>())
                            {
                                var key = item.ItemCodeId.ToString() + "_" + item.UnitId.ToString();
                                tvpPackingItems.Add(key, item);
                            }

                            grcPacking.SetDataSource(() =>
                            {
                                return packingItems;
                            });
                        }
                    }
                }

                if (FormMode == FormState.Edit)
                {

                    cmbCompany.Enabled = canEditPLDocument;
                    grpPL.Enabled = canEditPLDocument;
                    grpPLHeader.Enabled = canEditPLDocument;
                    tsGrcPacking.Enabled = true;

                    btnSave.Enabled = canSavePLDocument;
                    btnPost.Enabled = canPostPLDocument;
                    btnSaveAndPost.Enabled = canSavePLDocument && canPostPLDocument;

                    //Load data
                    if (this.documentId != null && this.packingDataRow != null)
                    {
                        var projectId = Convert.ToInt32(this.packingDataRow["ProjectId"]);
                        var companyId = Convert.ToInt32(this.packingDataRow["CompanyId"]);
                        var packingDocument = DAL.Do.GetPackingDocuments(projectId, LoginInfo.Id, companyId, documentId) as DataRow;

                        if (packingDocument == null) throw new CMISException("Document not found");
                        txtReport.Text = packingDocument["ReportNo"].ToString();
                        cmbCompany.EditValue = Convert.ToInt32(packingDocument["CompanyId"]);

                        var packingItems = DAL.Do.GetPackingItemsByDocumentId(this.documentId);
                        if (packingItems.Rows.Count > 0)
                        {                            
                            foreach (var item in packingItems.ToList<Model.TvpPackingItem>())
                            {
                                var key = item.ItemCodeId.ToString() + "_" + item.UnitId.ToString();
                                tvpPackingItems.Add(key, item);
                            }

                            grcPacking.SetDataSource(() =>
                            {
                                return packingItems;
                            });
                        }                        
                    }
                }

                if (FormMode == FormState.Save)
                {
                    grpPL.Enabled = canSavePLDocument;
                    grpPLHeader.Enabled = canSavePLDocument;
                    txtReport.Text = BEL.ReportNumber.PLReportNumber(cmbCompany.EditValue.ToInt());
                    btnNew.Enabled = btnSave.Enabled = btnSave.Group().Visible = canSavePLDocument;
                    btnNew.Visibility = btnSave.Visibility = btnSaveAndPost.Visibility = canSavePLDocument ? BarItemVisibility.Always : BarItemVisibility.Never;
                    btnSaveAndPost.Enabled = canSavePLDocument && canPostPLDocument;

                    btnPost.Enabled = btnPost.Group().Visible = false;

                    tsGrcPacking.Enabled = canSavePLDocument;

                    grcPacking.DataSource = null;
                    tvpPackingItems.Clear();
                }
            }
            catch (Exception)
            {
                throw;
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

                var key = cboItemCode.EditValue.ToString()+"_"+cboUnit.EditValue.ToString();
                //var itemKey = cboItemCode.GetColumnValue("ItemCode").ToString();

                // Data will be update
                if (tvpPackingItems.ContainsKey(key))
                {
                    var item = tvpPackingItems[key];                    
                    item.ItemCodeId = Convert.ToInt32(cboItemCode.EditValue);
                    item.ItemCode = cboItemCode.Text;
                    item.UnitId = Convert.ToInt32(cboUnit.EditValue);
                    item.VendorId = Convert.ToInt32(cboVendor.EditValue);
                    item.TagNo = txtTag.Text.Trim();
                    item.CategoryId = Convert.ToInt32(cboTreeCategory.EditValue);
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
                        CategoryId = Convert.ToInt32(cboTreeCategory.EditValue),
                        Description = txtDescription.Text.Trim(),
                        Size = txtSize.Text.Trim(),
                        PackingNo = txtPackingNo.Text.Trim(),
                        PLQty = Convert.ToDecimal(txtPlQty.Text.Trim()),
                        QtyUnitId = Convert.ToInt32(cboQtyUnit.EditValue)
                    };
                    tvpPackingItems.Add(key, tvpPackingItem);
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
                if (Msg.Confirm("Are you sure to remove selected item") == DialogResult.No) return;
                if(grvPaking.GetFocusedDataRow() is DataRow dr)
                {
                    //tvpPackingItems.Remove(dr["keyDictionary"].ToString());
                    var unitId = dr["UnitId"].ToInt();
                    var itemCodeId = dr["ItemCodeId"].ToInt();
                    var key = itemCodeId + "_" + unitId;
                    tvpPackingItems.Remove(key);
                    grvPaking.DeleteSelectedRows();
                    FillPackingListGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cboItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtSize.Text = cboItemCode.GetColumnValue("Size").ToString();
                txtDescription.Text = cboItemCode.GetColumnValue("Remark").ToString();
                cboQtyUnit.EditValue = cboItemCode.GetColumnValue("QtyUnitId").ToInt();
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
                if (FormMode == FormState.View) return;
                if (!ACL.EditPLDocument.AllowAcl(this)) throw new CMISException("Dear user, you don't have access to edit PL document!");
                if (grvPaking.GetFocusedDataRow() is DataRow dr)
                {
                    if (Msg.Confirm("Are you sure to edit selected item") == DialogResult.No) return;
                    grpPL.Enabled = true;
                    cboUnit.EditValue = Convert.ToInt32(dr["UnitId"]);
                    cboTreeCategory.EditValue = dr["CategoryId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CategoryId"]);
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
                cboUnit.SelectItem(0);
                cboTreeCategory.EditValue = 0;
                cboItemCode.SelectItem(0);
                txtTag.Text = String.Empty;
                txtPackingNo.Text = String.Empty;
                cboVendor.SelectItem(0);
                txtSize.Text = String.Empty;
                txtPlQty.Text = "0.00";
                cboQtyUnit.SelectItem(0);
                txtDescription.Text = String.Empty;
                grpPL.Enabled = true;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
