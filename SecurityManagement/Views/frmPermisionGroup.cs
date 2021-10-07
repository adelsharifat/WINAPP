using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using CMISUtils;
using DevExpress.XtraGrid.Views.Grid;
using SecurityManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManagement.Views
{
    public partial class frmPermisionGroup : ViewTab
    {
        public frmPermisionGroup()
        {
            InitializeComponent();
            ViewTitle = "Group Permision";
        }

        private void frmPermisionGroup_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage.AddGridTools(this);
                e.RibbonPage.AddExportTools(this);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void frmUserPermision_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                FillCboProject();
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
                grcPermisionGroup.SetDataSource(()=> { 
                    return DAL.New.GetUserGroupList(Convert.ToInt32(cboProject.EditValue));
                }); 
                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillCboProject()
        {
            try
            {
                cboProject.Fill(CMISDAL.Common.CommonDals.Project.GetProjectList(), "Name", "Id");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grcPermisionGroup_DataLoaded(object sender, EventArgs e)
        {
            try
            {
                grcPermisionGroup.HideColumns("Id,ProjectId").AutoWidth(false).BestFit();
                grvPermisionGroup.TextCenter("Permision").TextUnderline("Permision").TextColor("Permision", Color.DarkBlue);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvUserPermision_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                grvPermisionGroup.HandCursor(e, "Permision");
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
                    var id = Convert.ToInt32(grvPermisionGroup.GetRowCellValue(e.RowHandle, "Id"));
                    var projectId = Convert.ToInt32(cboProject.EditValue);
                    CMISUI.UIHandler.ViewInForm<frmACL>(new object[] { id, true,projectId });
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void cboProject_EditValueChanged(object sender, EventArgs e)
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
