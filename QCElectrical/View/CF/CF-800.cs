using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using Security;
using DMS.ViewModel;
using CMISUtils;
using CMISUIHelper.Infrastructure.Enums;
using CMISDAL.Common;

namespace QCElectrical.View.CF
{
    public partial class CF_800 : ViewTab
    {
        List<FileAttachmentViewModel> fileAttachmentList = new List<FileAttachmentViewModel>();

        public CF_800()
        {
            InitializeComponent();
        }

        private void CF_800_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                this.RibbonPage.AddExportTools(this.OwnerView);
                var frmCF = (View.CF.frmCF)this.OwnerView;
                lblCFDescription.Text = frmCF.cmbCF.GetColumnValue("Description").ToString();
                FillAreaUnitCombo();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillAreaUnitCombo()
        {
            try
            {
                var data = CommonDals.Do.AreaUnit.FetchContractsCombo(LoginInfo.ProjectId);
                cmbUnit.Fill(data,"Name", "Id").HideColumns("AreaId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DMS.Attachment.Do.OpenFileDialog(txtFileAttachPath);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtFileAttachPath.Text))
                    return;

                DMS.Attachment.Do.AddAttachmentToGrid(fileAttachmentList, grcAttaochment, txtFileAttachPath.Text, LoginInfo.FullName, txtRemarkAttachment.Text.Trim(), this.Name)
                    .HideColumns("Id,FilePath,FileTableName,CustomType,FileName");
                DMS.Attachment.Do.ResetAttachmentControls(txtFileAttachPath,txtRemarkAttachment);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvAttachment_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DMS.Attachment.Do.ShowAttachment("CM.FetchFileStream", e, grcAttaochment, GlobaConfig.AttachmentDumpAddress);
            }
            catch (Exception ex)
            {

                ex.ShowMessage();
            }
        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMode == FormState.ReadMode) return;
                DMS.Attachment.Do.ClearAttachmentFromGrid(grcAttaochment, fileAttachmentList);
            }
            catch (Exception ex)
            {

                ex.ShowMessage();
            }
        }
    }
}
