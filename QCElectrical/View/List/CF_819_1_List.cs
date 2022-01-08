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
using QCElectrical.Data;
using Security;
using CMISUtils;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Enums;

namespace QCElectrical.View.List
{
    public partial class CF_819_1_List : ViewTab
    {
        // Normal constructor
        public CF_819_1_List()
        {
            InitializeComponent();
            ViewTitle = "CF_819_1 List";
        }


        private void CF_819_1_List_ViewLoaded(object sender, EventArgs e)
        {
            //Fill grid on load form
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                grcCF_819_1.SetDataSource(() =>
                {
                    return DAL.Do.FETCH_CF_801_19_1_LIST(LoginInfo.ProjectId);
                });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void CF_819_1_List_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            e.RibbonPage.AddViewFormActionTool(this);
            e.RibbonPage.AddEditFormActionTool(this);
            e.RibbonPage.AddDeleteFormActionTool(this);
            e.RibbonPage.AddLiteGridTools(this);

            var menuView = MenuItems["view"];
            var menuEdit = MenuItems["edit"];
            var menuDelete = MenuItems["delete"];

            menuView.ItemClick += MenuView_ItemClick;
            menuEdit.ItemClick += MenuEdit_ItemClick;
            menuDelete.ItemClick += MenuDelete_ItemClick;

            



        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var currentRow = grv_819_1.GetFocusedDataRow();
                if (currentRow == null) throw new CMISException("CurrentRow null expetion!");

                int documentId = currentRow.ToInt("DocumentId");
                CMISUI.UIHandler.ViewInTab<View.CF.CF_819_1>(this.OwnerForm, new object[] { documentId,FormState.View });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MenuEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var currentRow = grv_819_1.GetFocusedDataRow();
                if (currentRow == null) throw new CMISException("CurrentRow null expetion!");

                int documentId = currentRow.ToInt("DocumentId");
                CMISUI.UIHandler.ViewInTab<View.CF.CF_819_1>(this.OwnerForm,new object[]{ documentId,FormState.Edit });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MenuDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
