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
using CMISUIHelper.Infrastructure.Enums;
using CMISUtils;
using Electrical.Data;
using Security;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUtils.Extentions;
using CMISNewSecurity;

namespace Electrical.View
{
    public partial class ItemCode : ViewTab
    {
        private int? id = null;

        public ItemCode()
        {
            InitializeComponent();
            ShowRefreshItem = true;
            Grid = grcItemCode;
        }

        private void ItemCode_BeforeViewLoad(object sender, EventArgs e)
        {
            ViewTitle = AppConfig.ItemCode_View_Title;
            ResetForm();
            FillCategoriesCombo();
        }



        //Load form event
        private void ItemCode_ViewLoaded(object sender, EventArgs e)
        {
            LoadData();
        }


        //Refreshed form here
        private void ItemCode_ViewRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        //Ribbon page added event
        private void ItemCode_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            var btnEditItem = e.RibbonPage.AddEditFormActionTool(this);
            var btnDeleteItem = e.RibbonPage.AddDeleteFormActionTool(this);
            var btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);

            //Added ribbon grid tools
            e.RibbonPage.AddToggleSearchGridTool(this);
            e.RibbonPage.AddToggleAutoWidthGridTool(this);
            e.RibbonPage.AddToggleBestFitGridTool(this);

            //Handle event btnItems
            btnNewItem.ItemClick += BtnNewItem_ItemClick;
            btnEditItem.ItemClick += BtnEditItem_ItemClick;
            btnDeleteItem.ItemClick += BtnDeleteItem_ItemClick;
            btnSaveItem.ItemClick += BtnSaveItem_ItemClick;

            //SetPermission
            btnEditItem.AccessibleName = this.SetAcl(ACL.EditItemCode);
            btnDeleteItem.AccessibleName = this.SetAcl(ACL.DeleteItemCode);
            btnSaveItem.AccessibleName = this.SetAcl(ACL.SaveItemCode);
        }

        private void BtnNewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ResetForm();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnSaveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Validate form here
                FormValidation();

                Msg.ConfirmOperation("Are you sure to save item code?").Invoke();

                var categoryId = Convert.ToInt32(cboTreeCategory.EditValue);
                var warehouseItemCodeId = Convert.ToInt32(cboWarehouseItemCode.EditValue);
                var result = DAL.Do.SaveItemCode(this.id,categoryId,warehouseItemCodeId, txtItemCode.Text.Trim(),txtSize.Text.Trim(),cboQtyUnit.EditValue.ToInt(),txtRemark.Text.Trim(), LoginInfo.ProjectId, LoginInfo.Id);

                if (result <= 0) throw new CMISException("Save item code faild!");

                LoadData();
                ResetForm();
                Msg.Show("Save item code succeded!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        private void BtnEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMode = FormState.Edit;
            if (grvItemCode.GetFocusedDataRow() is DataRow dr)
            {
                this.id = dr.Id();
                txtItemCode.Text = dr.ToString("ItemCode");
                cboTreeCategory.EditValue =dr["CategoryId"] == DBNull.Value?0:dr.ToInt("CategoryId");
                cboWarehouseItemCode.EditValue = dr["WarehouseItemCodeId"] == DBNull.Value ? 0 : dr.ToInt("WarehouseItemCodeId");
                txtSize.Text = dr["Size"].ToString();
                cboQtyUnit.EditValue = dr["QtyUnitId"].ToInt();
                txtRemark.Text = dr["Remark"].ToString();
            }
        }
        private void BtnDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(Msg.Confirm("Are you sure to delete item code?")==DialogResult.No) return;
                if (grvItemCode.GetFocusedDataRow() is DataRow dr)
                {
                    var id = dr.Id();
                    var result = DAL.Do.DeleteItemCode(id, LoginInfo.ProjectId, LoginInfo.Id);
                    if (result <= 0) throw new CMISException("Delete item code faild!");
                    LoadData();
                    ResetForm();
                    Msg.Show("Delete item code succeded!");
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Load form data
        private void LoadData()
        {
            FillGrvItemCode();
            FillCategoriesCombo();
            FillWarehouseItemCodesCombo();
            FillPLQtyUnit();
        }

        private void FillGrvItemCode()
        {
            try
            {
                var data = DAL.Do.GetItemCodes(LoginInfo.ProjectId,LoginInfo.Id);
                grcItemCode.DataSource = data;
                if(data is DataTable dt)
                {
                    //grcItemCode.SetDataSource(() =>
                    //{
                    //    return dt;
                    //});
                    grcItemCode.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        private void FormValidation()
        {
            try
            {
                if (String.IsNullOrEmpty(txtItemCode.Text)) throw new CMISException("Item code field is required!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ResetForm()
        {
            FormMode = FormState.Save;
            txtItemCode.Text = String.Empty;
            txtRemark.Text = String.Empty;
            txtSize.Text = String.Empty;

        }
        private void gvItemCode_DoubleClick(object sender, EventArgs e)
        {
            BtnEditItem_ItemClick(sender, null);
        }

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
        private void FillWarehouseItemCodesCombo()
        {
            try
            {
                var data = DAL.Do.GetWarehouseItemCodesCombo();
                cboWarehouseItemCode.Fill(data, "ItemCode", "Id").SelectItem(0);
            }
            catch (Exception)
            {
                throw;
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


    }
}
