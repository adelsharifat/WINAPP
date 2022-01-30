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
using QCElectrical.Infrastructure;

namespace QCElectrical.View.List
{
    public partial class CF_List : ViewTab
    {
        // Normal constructor
        public CF_List()
        {
            InitializeComponent();
            ViewTitle = "CF List";
        }


        private void CF_List_ViewLoaded(object sender, EventArgs e)
        {
            //Fill grid on load form
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                grcCF.SetDataSource(() =>
                {
                    return DAL.Do.FETCH_CF_LIST(LoginInfo.ProjectId);
                });


                grvCF.SetConditionRowFormat("IsDelete", "[IsDelete]=1", new DevExpress.Utils.AppearanceDefault { BackColor = System.Drawing.Color.FromArgb(255, 224, 234), Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Italic) });

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void CF_List_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            e.RibbonPage.AddViewFormActionTool(this);
            e.RibbonPage.AddEditFormActionTool(this);

            var menuView = MenuItems["view"];
            var menuEdit = MenuItems["edit"];

            menuView.ItemClick += MenuView_ItemClick;
            menuEdit.ItemClick += MenuEdit_ItemClick;

        }

        private void RefreshMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Msg.Show("refresh menu worked!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var currentRow = grvCF.GetFocusedDataRow();
                if (currentRow == null) throw new CMISException("CurrentRow null expetion!");

                var documentId = currentRow.DocumentId();
                var cfId = currentRow.Id();
                var cfTypeId = (CFType)currentRow.ToInt("CFTypeId");
                OpenCF(documentId, cfId, cfTypeId,FormState.View);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void OpenCF(int documentId, int cfId, CFType cfTypeId,FormState formState)
        {
            switch (cfTypeId)
            {
                case CFType.CF_819_1:
                    CMISUI.UIHandler.ViewInTab<View.CF.CF_819_1>(this.OwnerForm, new object[] { documentId, cfId, formState });
                    break;
                case CFType.CF_819_2:
                    CMISUI.UIHandler.ViewInTab<View.CF.CF_819_2>(this.OwnerForm, new object[] { documentId, cfId, formState });
                    break;
            }
        }

        private void MenuEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var currentRow = grvCF.GetFocusedDataRow();
                if (currentRow == null) throw new CMISException("CurrentRow null expetion!");

                int documentId = currentRow.ToInt("DocumentId");
                var cfId = currentRow.Id();
                var cfTypeId = (CFType)currentRow.ToInt("CFTypeId");
                OpenCF(documentId, cfId, cfTypeId, FormState.Edit);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void CF_List_ViewRefresh(object sender, EventArgs e)
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
