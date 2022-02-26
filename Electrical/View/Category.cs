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
using DevExpress.XtraBars;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Enums;
using Electrical.Data;
using CMISUtils;
using Security;
using CMISNewSecurity;

namespace Electrical.View
{
    public partial class Category : ViewTab
    {
        private int? id = null;
        public Category()
        {
            InitializeComponent();
            ViewTitle = "Category";
            ShowRefreshItem = true;
        }

        private void Category_BeforeViewLoad(object sender, EventArgs e)
        {
            ViewTitle = AppConfig.Category_View_Title;
        }

        private void Category_ViewLoaded(object sender, EventArgs e)
        {
            //Load form data;
            LoadData();
        }

        private void Category_ViewRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Category_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            var btnEditItem = e.RibbonPage.AddEditFormActionTool(this);
            var btnDeleteItem = e.RibbonPage.AddDeleteFormActionTool(this);
            var btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);

            //Handle event btnItems
            btnNewItem.ItemClick += BtnNewItem_ItemClick;
            btnEditItem.ItemClick += BtnEditItem_ItemClick;
            btnDeleteItem.ItemClick += BtnDeleteItem_ItemClick;
            btnSaveItem.ItemClick += BtnSaveItem_ItemClick;

            //SetPermission
            btnEditItem.AccessibleName = this.SetAcl(ACL.EditCategory);
            btnDeleteItem.AccessibleName = this.SetAcl(ACL.DeleteCategory);
            btnSaveItem.AccessibleName = this.SetAcl(ACL.SaveCategory);
        }

        private void BtnNewItem_ItemClick(object sender, ItemClickEventArgs e)
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
        private void BtnSaveItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Validate form here
                FormValidation();

                //if (Msg.Confirm("Are you sure to save item code?") == DialogResult.No) return;
                Msg.ConfirmOperation("Are you sure to save category?").Invoke();


                var result = DAL.Do.SaveCategory(LoginInfo.ProjectId, LoginInfo.Id, this.id ,Convert.ToInt32(cboTreeCategory.EditValue),txtSubCategory.Text.Trim());

                if (result <= 0) throw new CMISException("Save category faild!");

                LoadData();
                ResetForm();
                Msg.Show("Save category succeded!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        private void BtnEditItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormMode = FormState.Edit;
            if (treeCategory.GetFocusedDataRow() is DataRow dr)
            {
                this.id = dr.Id();
                txtSubCategory.Text = dr.ToString("Category");
                cboTreeCategory.EditValue = dr["ParentId"] == DBNull.Value?0:dr.ToInt("ParentId");
            }
        }
        private void BtnDeleteItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //if (Msg.Confirm("Are you sure to save item code?") == DialogResult.No) return;
                Msg.ConfirmOperation("Are you sure to delete category?").Invoke();
                if (treeCategory.GetFocusedDataRow() is DataRow dr)
                {
                    var id = dr.Id();
                    var result = DAL.Do.DeleteCategory(id, LoginInfo.ProjectId, LoginInfo.Id);
                    if (result <= 0) throw new CMISException("Delete category faild!");
                    LoadData();
                    ResetForm();
                    Msg.Show("Delete category succeded!");

                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }


        //Misc Method
        private void LoadData()
        {
            try
            {
                FillCategoriesCombo();
                FillTreeList();
                ResetForm();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillTreeList()
        {
            try
            {
                var data = DAL.Do.GetCategories(LoginInfo.ProjectId, LoginInfo.Id);
                if (data is DataTable dt)
                {
                    treeCategory.DataSource = dt;
                    treeCategory.ParentFieldName = "ParentId";
                }
            }
            catch (Exception)
            {
                throw;
            }
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


        private void FormValidation()
        {
            try
            {
                if (String.IsNullOrEmpty(txtSubCategory.Text)) throw new CMISException("Subcategory field is required!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ResetForm()
        {
            FormMode = FormState.Save;
            this.id = null;
            txtSubCategory.Text = String.Empty;
        }


    }
}
