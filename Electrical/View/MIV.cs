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
using CMISSecurity;
using Electrical.Model;
using CMISUtils.Extentions;

namespace Electrical.View
{
    public partial class MIV : ViewTabWithCompany
    {
        Dictionary<int, MIVItem> mivItemsDictionary = new Dictionary<int, MIVItem>();

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
                FillMIVItemCodeCombo();
            }
            catch (Exception ex)
            {
                throw ex;
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
        private void SetMivItemGridEditableColumns()
        {
            grcMIVItems.EditableColumns("Qty,Remark");
            var qtyColumn = grvMIVItems.Columns["Qty"];
            var remarkColumn = grvMIVItems.Columns["Remark"];
            qtyColumn.AppearanceHeader.BackColor = qtyColumn.AppearanceCell.BackColor = Color.LightYellow;
            remarkColumn.AppearanceHeader.BackColor = remarkColumn.AppearanceCell.BackColor = Color.LightYellow;
        }

        private void MIV_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void MIV_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                //Form action tools
                var btnNew =e.RibbonPage.AddNewFormActionTool(this);               
                var btnSave = e.RibbonPage.AddSaveFormActionTool(this);
                var btnSaveAndPost = CMISUI.RibbonHandler.NewItem.ButtonItem("Save&Post", null, ElectricalResource.export_32x32);
                btnSave.Group().AddItems(btnSaveAndPost);

                //Sign action tools
                var btnPost = e.RibbonPage.AddSignPostActionTool(this);

                //Grid tools
                e.RibbonPage.AddGridTools(this);

                btnNew.ItemClick += BtnNew_ItemClick;
                btnSave.ItemClick += BtnSave_ItemClick;

                //Set permission
                btnSave.Enabled = ACL.ButtonSaveMIVDocument.AllowAcl(this);
                btnSaveAndPost.Enabled = ACL.ButtonSaveMIVDocument.AllowAcl(this) && ACL.ButtonPostMIVDocument.AllowAcl(this);
                btnPost.Enabled = ACL.ButtonPostMIVDocument.AllowAcl(this) && ACL.MIVCreator.AllowAcl(this);
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                var balance = Convert.ToInt32(cboItemCode.GetColumnValue("Balance"));
                if (balance == 0f) throw new CMISException("Inventory item is zero!");
                if (Convert.ToDecimal(txtQty.Text) > balance) throw new CMISException("Item inventory is not enough for the requested amount");

                //data
                var inventoryBalanceId = cboItemCode.EditValue.ToInt();
                var itemCode = cboItemCode.GetColumnValue("ItemCode").ToString();
                var unit = cboItemCode.GetColumnValue("Unit").ToString();
                var company = cboCompanies.GetColumnValue("FullName").ToString();
                var qty = txtQty.Text.ToDecimal();
                var remark = txtItemRemark.Text.Trim();

                //Generate unique key for dictionary
                var key = inventoryBalanceId;

                if (mivItemsDictionary.ContainsKey(key)) throw new CMISException("ItmCode already added to list you can change Qty value from the grid cell value!");

                var mivItemModel = new MIVItem
                {
                    InventoryBalanceId = 0,
                    ItemCode = itemCode,
                    Unit = unit,
                    Company = company,
                    Qty = qty,
                    Remark = remark
                };

                //Validate mivitem before add to grid
                ValidateMivItem(mivItemModel);            

                mivItemsDictionary.Add(key, mivItemModel);

           

                FillMivItemGrid();
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
                grcMIVItems.HideColumns("Id,CompanyId,UnitId,ItemCodeId");
                SetMivItemGridEditableColumns();
            }
        }

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
        private void FillMIVItemCodeCombo()
        {
            try
            {
                var data = DAL.Do.GetMIVItemCodesCombo();
                cboItemCode.Fill(data, "ItemCode", "InventoryBalanceId").SelectItem(0).HideColumns("CompanyId,UnitId,ItemCodeId");
                cboItemCode.Properties.PopupWidth = 600;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        #endregion

        private void grvMIVItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if(e.Row is DataRow dr)
                {
                    var key = dr["InventoryBalanceId"].ToInt();
                    var newQty = dr["Qty"].ToDecimal();
                    var newRemark = dr["Remark"].ToString();
                    mivItemsDictionary[key].Qty = newQty; 
                    mivItemsDictionary[key].Remark = newRemark;
                    //Refresh Grid
                    FillMivItemGrid();
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();                
            }
        }

        private void grvMIVItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grvMIVItems.GetFocusedDataRow() is DataRow dr)
                {
                    cboCompanies.EditValue = dr["CompanyId"].ToInt();
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
    }
}
