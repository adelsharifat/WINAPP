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
using CMISBEL.Core.Common;

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
                var frmCF = (View.CF.frmCF)this.OwnerView;
                lblCFDescription.Text = frmCF.cmbCF.GetColumnValue("Description").ToString();
                FillAreaUnitCombo();
                FillDWGNo();
                Fill_txtReportNumber();
                var documentStatus = "OnCreating";
                GenerateBarCode(documentStatus);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void GenerateBarCode(string documentStatus)
        {
            brcReportNumber.Text = String.Empty;
            brcReportNumber.Visible = false;
            brcReportNumber.Text = txtReportNo.Text + $"[{documentStatus}]";
            brcReportNumber.Visible = true;
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

        private void FillDWGNo()
        {
            try
            {
                var data = CommonDals.Do.DWGNo.FetchDWGNo();
                cmbDwgNo.Fill(data, "DWG No.", "RevisionId").HideColumns("");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Fill_txtReportNumber()
        {
            try
            {
                txtReportNo.Text = Report().ReportNumber;                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private ReportNumberViewModel Report()
        {
            try
            {
                var disciplineId = Convert.ToInt32(belConfig.Do.Config(LoginInfo.ProjectId, AppConst.ScopeInConfig)["DisciplineId"]);
                var employerId = Convert.ToInt32((this.OwnerView as frmCF).cmbCompany.GetColumnValue("EmployerId"));
                var companyId = Convert.ToInt32((this.OwnerView as frmCF).cmbCompany.GetColumnValue("ContractorId"));
                var cmbCFText = (this.OwnerView as frmCF).cmbCF.Text;
                var cfType = belConfig.Do.Config(LoginInfo.ProjectId, AppConst.ScopeInConfig)[cmbCFText].ToString();
                var report = DMS.ReportNumber.Do.Generate("QCElectrical", LoginInfo.ProjectId, 1051, employerId, companyId, "{[CFType]}," + cfType);
                ReportNumberViewModel rnvm = new ReportNumberViewModel
                {
                    ReportNumber = report.ReportNumber,
                    CounterId = report.CounterId
                };
                return rnvm;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
                return null;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DMS.Attachment.Do.OpenFileDialog(txtFileAttachPath,txtRemarkAttachment);
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

        private void cmbDwgNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblREVNo.Text = cmbDwgNo.GetColumnValue("RevNo")?.ToString();
                lblTAGNo.Text = cmbDwgNo.GetColumnValue("TagNo")?.ToString();
                txtCustomTagNo.Text = cmbDwgNo.GetColumnValue("TagNo")?.ToString();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
