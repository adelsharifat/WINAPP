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
using Electrical.Data;
using Security;
using CMISDAL.Common;
using CMISUtils;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.Infrastructure.Contracts.CustomException;

namespace Electrical.View
{
    public partial class PackingList : ViewTabWithCompany
    {
        public PackingList()
        {
            InitializeComponent();
            this.ShowRefreshItem = true;
        }

        private void PackingList_BeforeViewLoad(object sender, EventArgs e)
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

        private void PackingList_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void PackingList_ViewRefresh(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void PackingList_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                var btnViewItem = e.RibbonPage.AddViewFormActionTool(this);
                var btnEditItem = e.RibbonPage.AddEditFormActionTool(this);
                var btnDeleteItem = e.RibbonPage.AddDeleteFormActionTool(this);

                e.RibbonPage.AddGridTools(this);
                e.RibbonPage.AddExportTools(this);

                btnViewItem.ItemClick += BtnViewItem_ItemClick;
                btnEditItem.ItemClick += BtnEditItem_ItemClick;
                btnDeleteItem.ItemClick += BtnDeleteItem_ItemClick;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (grvPackingList.GetFocusedDataRow() is DataRow dr)
                {
                    var documentId = Convert.ToInt32(dr["Id"]);
                    var posted = Convert.ToBoolean(dr["Posted"]);
                    if (posted) throw new CMISException("The document posted and can not delete it!");
                    Msg.Show("The document deleted!");
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (grvPackingList.GetFocusedDataRow() is DataRow dr)
                {
                    var documentId = Convert.ToInt32(dr["Id"]);
                    var posted = Convert.ToBoolean(dr["Posted"]);
                    if (posted) throw new CMISException("The document posted and can not edit it!");
                    CMISUI.UIHandler.ViewInTab<View.Packing>(this.OwnerForm, new object[] { documentId, dr, FormState.Edit });
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void BtnViewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(grvPackingList.GetFocusedDataRow() is DataRow dr)
            {
                var documentId = Convert.ToInt32(dr["Id"]);
                CMISUI.UIHandler.ViewInTab<View.Packing>(this.OwnerForm, new object[]{ documentId,dr,FormState.View });
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


        //Helper functions

        private void FillGrid()
        {
            try
            {
                var data = DAL.Do.GetPackingDocuments(LoginInfo.ProjectId, Convert.ToInt32(cmbCompany.EditValue), null);
                grcPackingList.SetDataSource(() =>
                {
                    return data;
                });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cmbCompany_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
