using CMISDAL.Common;
using CMISUIHelper.Infrastructure.Contracts.CustomAttributes;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using CMISUtils;
using DevExpress.XtraGrid.Views.Grid;
using SecurityManagement.Data;
using SecurityManagement.Infrastructure.Const;
using SecurityManagement.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SecurityManagement.Views
{
    [AppSchema(AppConst.Schema)]
    [RibbonMenuItem("User Permision", 1)]
    [RibbonMenuGroup("Permision", 1)]
    [RibbonItemIcon(AppConst.ResourceName, "window_32x32")]
    public partial class frmUserPermision : ViewTab
    {
        public frmUserPermision()
        {
            InitializeComponent();
            ViewTitle = "User Permision";            
        }

        private void frmUserPermision_ViewLoaded(object sender, EventArgs e)
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

        private void FillGrid()
        {
            try
            {
                grcUserPermision.SetDataSource(() =>
                {
                    return DAL.New.GetUserList();
                });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grcUserPermision_DataLoaded(object sender, EventArgs e)
        {
            grcUserPermision.HideColumns("Id,FirstName");
            grvUserPermision.TextCenter("Permision").TextUnderline("Permision").TextColor("Permision",Color.DarkBlue);
        }

        private void grvUserPermision_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                grvUserPermision.HandCursor(e, "Permision");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvUserPermision_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colPermision")
                {
                    var id = Convert.ToInt32(grvUserPermision.GetRowCellValue(e.RowHandle, "Id"));
                    CMISUI.UIHandler.ViewInNormalForm<frmACL>(this,new object[]{ id,false,null });
                }
            }
            catch (Exception ex)
            {

                ex.ShowMessage();
            }
        }

        private void frmUserPermision_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage.AddGridTools(this);
                e.RibbonPage.AddCloseItem(this);
                e.RibbonPage.AddExportTools(this);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
