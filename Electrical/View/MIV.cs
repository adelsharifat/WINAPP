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
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISNewSecurity;
using Electrical.Model;
using CMISUtils.Extentions;
using DevExpress.XtraGrid.Views.Grid;
using CMISUIHelper.Infrastructure.Enums;
using DMS.Enums;

namespace Electrical.View
{
    public partial class MIV : ViewTabWithCompany
    {
        Dictionary<string, MIVItem> mivItemsDictionary = new Dictionary<string, MIVItem>();
        private int? documentId = null;
        private DataRow mivDataRow = null;

        private BarItem btnNew,btnSave, btnSaveAndPost, btnPost;

        public MIV()
        {
            InitializeComponent();
            FormMode = FormState.Save;
        }

        public MIV(DataRow dr,FormState formMode)
        {
            InitializeComponent();
            this.mivDataRow = dr;
            this.documentId = dr.Id();
            FormMode = formMode;
        }


        private void MIV_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitComboCompany();
                FillCompaniesCombo();

                this.Grid = grcMIVItems;

                GoToCurrentFormState();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MIV_ViewLoaded(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        //Set som columns as editable // light yellow back color columns is editable
        private void SetMivGridEditable(bool canEdit = true)
        {
            grvMIVItems.OptionsBehavior.Editable = canEdit;
            grcMIVItems.EditableColumns("Qty,Remark");
            var qtyColumn = grvMIVItems.Columns["Qty"];
            var remarkColumn = grvMIVItems.Columns["Remark"];
            qtyColumn.AppearanceHeader.BackColor = qtyColumn.AppearanceCell.BackColor = Color.LightYellow;
            remarkColumn.AppearanceHeader.BackColor = remarkColumn.AppearanceCell.BackColor = Color.LightYellow;

            //set format value for specific columns
            qtyColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            qtyColumn.DisplayFormat.FormatString = "n2";
        }

        private void MIV_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void MIV_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                //Form action tools
                btnNew =e.RibbonPage.AddNewFormActionTool(this);               
                btnSave = e.RibbonPage.AddSaveFormActionTool(this);
                btnSaveAndPost = CMISUI.RibbonHandler.NewItem.ButtonItem("SavePost", null, ElectricalResource.export_32x32);
                btnPost = e.RibbonPage.AddSignPostActionTool(this);

                //Add Cutom Item to menuCollection
                MenuItems.Add(btnSaveAndPost.Caption.ToLower(), btnSaveAndPost);

                btnSave.Group().AddItems(btnSaveAndPost);

                //Form Crud Action
                btnNew.ItemClick += BtnNew_ItemClick;
                btnSave.ItemClick += BtnSave_ItemClick;
                btnSaveAndPost.ItemClick += BtnSaveAndPost_ItemClick;

                //Sign action tools                
                
                btnPost.ItemClick += BtnPost_ItemClick;

                //Grid tools
                e.RibbonPage.AddGridTools(this);


                //Set permission
                btnSave.Enabled = ACL.SaveMIVDocument.AllowAcl(this);
                btnSaveAndPost.Enabled = ACL.SaveMIVDocument.AllowAcl(this) && ACL.PostMIVDocument.AllowAcl(this) && ACL.MIVCreator.AllowAcl(this);
                btnPost.Enabled = ACL.PostMIVDocument.AllowAcl(this) && ACL.MIVCreator.AllowAcl(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

  

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboItemCode.EditValue == null) return;
                var balance = cboItemCode.GetColumnValue("Balance")?.ToDecimal();
                if (balance == 0m) throw new CMISException("Inventory item is zero!");
                if (Convert.ToDecimal(txtQty.Text) > balance) throw new CMISException("Item inventory is not enough for the requested amount");

                //data
                var inventoryBalanceId = cboItemCode.EditValue.ToInt();
                var itemCodeId = cboItemCode.GetColumnValue("ItemCodeId").ToInt();
                var unitId = cboItemCode.GetColumnValue("UnitId").ToInt();
                var companyId = cboWhareHouseCompany.EditValue.ToInt();
                var itemCode = cboItemCode.GetColumnValue("ItemCode").ToString();
                var unit = cboItemCode.GetColumnValue("Unit").ToString();
                var company = cboWhareHouseCompany.GetColumnValue("FullName").ToString();
                var qty = txtQty.Text?.ToDecimal();
                var remark = txtItemRemark.Text.Trim();


                var mivItemModel = new MIVItem
                {
                    Id = 0,
                    InventoryBalanceId = inventoryBalanceId,
                    ItemCodeId = itemCodeId,
                    UnitId = unitId,
                    CompanyId = companyId,
                    ItemCode = itemCode,
                    Unit = unit,
                    Company = company,
                    Qty = (decimal)qty,
                    Balance = (decimal)balance,
                    Remark = remark
                };

                //Generate unique key for dictionary
                var key = mivItemModel.KeyDictionary;

                if (mivItemsDictionary.ContainsKey(key)) throw new CMISException("ItmCode already added to list you can change Qty value from the grid cell value!");

                //Validate mivitem before add to grid
                ValidateMivItem(mivItemModel);

                mivItemsDictionary.Add(key, mivItemModel);
                FillMivItemGrid();
                SetMivGridEditable();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMode = FormState.Save;
            ResetForm();
            GoToCurrentFormState();
        }        

        private void BtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                // Check form mode
                if (FormMode == FormState.View) return;

                //Check Grid in empty
                if (grvMIVItems.RowCount <= 0) return;

                //Prompt for save or updating data
                var formOperationMode = this.documentId == null ? "save" : "update";
                if (Msg.Confirm($"Are you sure for {formOperationMode} data?") == DialogResult.No) return;

                this.GridDefaultView.CloseEditor();
                if (!this.GridDefaultView.PostEditor()) throw new CMISException("Grid on modify data");

                //Create tvp for miv items
                var tvpMivItem = mivItemsDictionary.Select(x => x.Value).Select(x => new TvpMIV
                {
                    Id = x.Id,
                    InventoryBalnceId= x.InventoryBalanceId,
                    ItemCodeId = x.ItemCodeId,
                    WarehouseCompanyId = x.CompanyId,
                    UnitId = x.UnitId,
                    Qty = x.Qty,
                    Remark = x.Remark
                }).ToDataTable();


                var saveMIV = new SaveMIV
                {
                    DocumentId = this.documentId,
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ContractId = cmbCompany.EditValue.ToInt(),
                    CompanyId = cboWhareHouseCompany.EditValue.ToInt(),
                    ContractorId = cmbCompany.GetColumnValue("ContractorId").ToInt(),
                    Remark = txtDocuemntRemark.Text.Trim(),
                    MIVItems = tvpMivItem
                };


                //Save miv document here
                var result = DAL.Do.SaveMIVDocument(saveMIV);


                if (result <= 0) throw new CMISException($"Operation {formOperationMode} faild!");
                ResetForm();
                Msg.Show($"Operation {formOperationMode} succeded!");

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //check user only document is open or in edit mode documentId is nt null
                if (this.documentId == null) throw new CMISException("Document not found!");
                if (mivDataRow.Posted()) throw new CMISException("Dear user,The packing document already posted!");
                if (Msg.Confirm("Are you sure to post document?") == DialogResult.No) return;

                var signMIV = new SignMIV
                {
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ObjectId = this.documentId,
                    MachineName = SecurityHelper.MachineName,
                    ActiveDirectoryName = SecurityHelper.ActiveDirecotryName,
                    CompanyId = cboWhareHouseCompany.EditValue.ToInt()
                };

                var result = DAL.Do.SignMIVDocument(signMIV);

                if (result <= 0) throw new CMISException("Operation sign \"MIV\" faild!");

                Msg.Show("Operationm sign \"MIV\" succeded!");

                ResetForm();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnSaveAndPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Check form mode
                if (FormMode == FormState.View) return;

                //Check Grid in empty
                if (grvMIVItems.RowCount <= 0) return;

                if (mivDataRow.Posted()) throw new CMISException("Dear user,The packing document already posted!");
                if (Msg.Confirm("Are you sure to save and post document?") == DialogResult.No) return;

                //Save and sign action start from here
                this.GridDefaultView.CloseEditor();
                if (!this.GridDefaultView.PostEditor()) throw new CMISException("Grid on modify data");

                //Create tvp for miv items
                var tvpMivItem = mivItemsDictionary.Select(x => x.Value).Select(x => new TvpMIV
                {
                    Id = x.Id,
                    InventoryBalnceId = x.InventoryBalanceId,
                    ItemCodeId = x.ItemCodeId,
                    WarehouseCompanyId = x.CompanyId,
                    UnitId = x.UnitId,
                    Qty = x.Qty,
                    Remark = x.Remark
                }).ToDataTable();
           
                var saveMIV = new SaveMIV
                {
                    DocumentId = this.documentId,
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ContractId = cmbCompany.EditValue.ToInt(),
                    CompanyId = cboWhareHouseCompany.EditValue.ToInt(),
                    ContractorId = cmbCompany.GetColumnValue("ContractorId").ToInt(),
                    Remark = txtDocuemntRemark.Text.Trim(),
                    MIVItems = tvpMivItem   
                };

                var signMIV = new SignMIV
                {
                    ProjectId = LoginInfo.ProjectId,
                    UserId = LoginInfo.Id,
                    ObjectId = this.documentId,
                    MachineName = SecurityHelper.MachineName,
                    ActiveDirectoryName = SecurityHelper.ActiveDirecotryName,
                    CompanyId = cboWhareHouseCompany.EditValue.ToInt()
                };


                var result = DAL.Do.SaveAndSignMIVDocument(saveMIV,signMIV);

                if (result <= 0) throw new CMISException("Operation sign \"MIV\" faild!");

                Msg.Show("Operationm sign \"MIV\" succeded!");

                ResetForm();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        #region Helpers


        private void ValidateMivItem(MIVItem miv)
        {
            try
            {
                //validation data
                if (miv.ItemCodeId<=0) throw new CMISException("ItemCodeId is not valid!");
                if (miv.UnitId<=0) throw new CMISException("UnitId is not valid!");
                if (miv.CompanyId<=0) throw new CMISException("CompanyId is not valid!");
                if (miv.ItemCode.IsEmpty()) throw new CMISException("ItemCode is emtpy!");
                if (miv.Unit.IsEmpty()) throw new CMISException("Unit is emtpy!");
                if (miv.Qty <= 0) throw new CMISException("Qty is not valid!");
                if (miv.Remark.IsEmpty()) throw new CMISException("Remark is empty and you need enter remark minimum 9 charachter!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ConvertMivDictionaryToDataTable()
        {
            return mivItemsDictionary.ToList().Select(x=>x.Value).ToDataTable();
        }

        private void FillMivItemGrid()
        {
            var dt = ConvertMivDictionaryToDataTable();
            if (dt.Rows.Count>0)
            {
                grcMIVItems.DataSource = dt;
                grcMIVItems.HideColumns($"Id,CompanyId,UnitId,ItemCodeId,KeyDictionary,InventoryBalanceId");
            }
        }

        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.Id,LoginInfo.ProjectId, $"{Bundle.SCHEMA}.Contract");
                this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillCompaniesCombo()
        {
            try
            {
                var data = CommonDals.Do.Company.FetchCompaniesCombo(LoginInfo.Id,LoginInfo.ProjectId, $"{Bundle.SCHEMA}.Company");
                this.cboWhareHouseCompany.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("Symbol");
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        //Fill itemcode combo
        private void FillMIVItemCodeCombo(int projectId,int? warehouseCompanyId)
        {
            try
            {
                var data = DAL.Do.GetMIVItemCodesCombo(projectId,warehouseCompanyId);
                cboItemCode.Fill(data, "ItemCode", "InventoryBalanceId").SelectItem(0).HideColumns("CompanyId,UnitId,ItemCodeId");
                cboItemCode.Properties.PopupWidth = 600;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        #endregion

        private void grvMIVItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grvMIVItems.GetFocusedDataRow() is DataRow dr)
                {
                    cboWhareHouseCompany.EditValue = dr["CompanyId"].ToInt();
                    cboItemCode.EditValue = dr["InventoryBalanceId"].ToInt();
                    txtItemRemark.Text = dr["Remark"].ToString();
                    txtQty.Text = dr["Qty"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvMIVItems_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view.FocusedColumn.FieldName == "Qty")
                {
                    decimal qty = 0m;
                    if (!Decimal.TryParse(e.Value as String, out qty))
                    {
                        e.Valid = false;
                        e.ErrorText = "Only numeric values are accepted.";
                    }

                    var balance = view.GetCellValue("Balance")?.ToDecimal();

                    if(qty > balance)
                    {
                        e.Valid = false;
                        e.ErrorText = "Qty is greater than balance value.";
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvMIVItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Qty" || e.Column.FieldName == "Remark")
            {
                var dr = this.GridDefaultView.GetDataRow(e.RowHandle);
                var key = dr["KeyDictionary"].ToString();
                var newQty = dr["Qty"].ToDecimal();
                var newRemark = dr["Remark"].ToString();
                mivItemsDictionary[key].Qty = newQty.ToString("n2").ToDecimal();
                mivItemsDictionary[key].Remark = newRemark;
                //Refresh Grid
                FillMivItemGrid();
            }
        }

        private void ResetForm()
        {
            try
            {
                FormMode = FormState.Save;
                GoToCurrentFormState(); 
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void GoToCurrentFormState()
        {
            //GetPermissions
            var canViewMIVDocument = ACL.ViewMIVDocument.AllowAcl(this);
            var canSaveMIVDocument = ACL.SaveMIVDocument.AllowAcl(this);
            var canEditMIVDocument = ACL.EditMIVDocument.AllowAcl(this);
            var canPostMIVDocument = ACL.PostMIVDocument.AllowAcl(this);

            if (FormMode == FormState.View)
            {
                var posted = mivDataRow.Posted();
                var deleted = mivDataRow.IsDelete();
                pnlFields.Enabled = false;
                tspGrid.Enabled = false;           
                btnSave.Enabled = false;
                btnSaveAndPost.Enabled =btnSaveAndPost.Enabled = false;
                btnSave.Visibility = btnSaveAndPost.Visibility = BarItemVisibility.Never;
                btnPost.Enabled = btnPost.Group().Visible = canPostMIVDocument && !deleted && !posted;

                //Load data
                if (this.documentId != null && this.mivDataRow != null)
                {
                    var projectId = mivDataRow.ProjectId();
                    var mivDocument = DAL.Do.GetMIVDocuments(documentId,LoginInfo.Id,mivDataRow.ContractId(),projectId) as DataRow;

                    if (mivDocument == null) throw new CMISException("Document not found");
                    txtReport.Text = mivDocument.ReportNo();
                    txtDocuemntRemark.Text = mivDocument.Remark();
                    cmbCompany.EditValue = mivDocument.ContractId();
                    cboWhareHouseCompany.EditValue = mivDocument.CompanyId();
                    cmbCompany.Enabled = false;

                    var mivItems = DAL.Do.GetMIVItemsByDocumentId(this.documentId);
                    if (mivItems.Rows.Count > 0)
                    {
                        foreach (var item in mivItems.ToList<Model.MIVItem>())
                        {
                            mivItemsDictionary.Add(item.KeyDictionary, item);
                        }

                        FillMivItemGrid();
                        grcMIVItems.HideColumns("Balance");
                        grvMIVItems.OptionsBehavior.Editable = false;
                    }             
                }
            }

            if (FormMode == FormState.Edit)
            {
                cmbCompany.Enabled = canEditMIVDocument;
                pnlFields.Enabled = canEditMIVDocument;
                tspGrid.Enabled = canEditMIVDocument;         
                btnSave.Enabled = canSaveMIVDocument;
                btnSaveAndPost.Enabled = canSaveMIVDocument;
                btnPost.Enabled = canPostMIVDocument;
                btnSaveAndPost.Enabled = canSaveMIVDocument && canPostMIVDocument;

                //Load data
                if (this.documentId != null && this.mivDataRow != null)
                {
                    var projectId = mivDataRow.ProjectId();
                    var mivDocument = DAL.Do.GetMIVDocuments(documentId,LoginInfo.Id, mivDataRow.ContractId(), projectId ) as DataRow;

                    if (mivDocument == null) throw new CMISException("Document not found");
                    txtReport.Text = mivDocument.ReportNo();
                    txtDocuemntRemark.Text = mivDocument.Remark();
                    cmbCompany.EditValue = mivDocument.ContractId();
                    cboWhareHouseCompany.EditValue = mivDocument.CompanyId();

                    var mivItems = DAL.Do.GetMIVItemsByDocumentId(this.documentId);
                    if (mivItems.Rows.Count > 0)
                    {
                        foreach (var item in mivItems.ToList<Model.MIVItem>())
                        {
                            mivItemsDictionary.Add(item.KeyDictionary, item);
                        }

                        FillMivItemGrid();

                        SetMivGridEditable();
                    }                    
                }
            }

            if (FormMode == FormState.Save)
            {
                this.documentId = null;
                this.mivDataRow = null;

                pnlFields.Enabled = true;
               
                btnSave.Enabled = btnSave.Group().Visible = true;
                btnSave.Visibility = BarItemVisibility.Always;
                btnPost.Enabled = btnPost.Group().Visible = false;

                txtReport.Text = BEL.ReportNumber.MIVReportNumber(cboWhareHouseCompany.EditValue.ToInt(),cmbCompany.GetColumnValue("ContractorSymbol").ToString());
                txtDocuemntRemark.Text = String.Empty;
                txtItemRemark.Text = String.Empty;
                txtQty.Text = "0.00";

                tspGrid.Enabled = true;

                cmbCompany.Enabled = true;

                grcMIVItems.DataSource = null;
                mivItemsDictionary.Clear();               
            }
        }

        private void grvMIVItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if(grvMIVItems.GetDataRow(e.FocusedRowHandle) is DataRow dr)
                {
                    cboItemCode.EditValue = dr["InventoryBalanceId"].ToInt();
                    txtItemRemark.Text = dr["Remark"].ToString();
                    txtQty.Text = dr["Qty"].ToDecimal().ToString();
                }
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
                if (grvMIVItems.GetFocusedDataRow() is DataRow dr)
                {
                    if (Msg.Confirm("Are you sure to delete slected item!") == DialogResult.No) return;
                    var keyDictianary = dr["KeyDictionary"].ToString();
                    grvMIVItems.DeleteRow(grvMIVItems.FocusedRowHandle);
                    mivItemsDictionary.Remove(keyDictianary);
                    FillMivItemGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cboWhareHouseCompany_EditValueChanged(object sender, EventArgs e)
        {
            try
            {                
                FillMIVItemCodeCombo(LoginInfo.ProjectId, cboWhareHouseCompany.EditValue.ToInt());
                if(FormMode == FormState.Save)
                    GenerateReportNumber();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboWhareHouseCompany_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if(mivItemsDictionary.Count>0)
                {
                    if (Msg.Confirm("Dear user, After change warehouse company all data in the grid will be remove, Are you sure to change it?") == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }

                    ResetForm();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbCompany_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboWhareHouseCompany.EditValue != null)
                {
                    FillMIVItemCodeCombo(LoginInfo.ProjectId, cboWhareHouseCompany.EditValue.ToInt());
                    if(FormMode == FormState.Save)
                        GenerateReportNumber();
                }
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbCompany_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (mivItemsDictionary.Count > 0)
                {
                    if (Msg.Confirm("Dear user, After change document contract filed all data in the grid will be remove, Are you sure to change it?") == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }

                    ResetForm();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void GenerateReportNumber()
        {
            try
            {
                txtReport.Text = BEL.ReportNumber.MIVReportNumber(cboWhareHouseCompany.EditValue.ToInt(), cmbCompany.GetColumnValue("ContractorSymbol").ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
