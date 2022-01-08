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
using DevExpress.XtraBars;

namespace QCElectrical.View.CF
{
    public partial class CFTemp : ViewTabWithCompany
    {
        List<FileAttachmentViewModel> fileAttachmentList = new List<FileAttachmentViewModel>();

        public CFTemp()
        {
            InitializeComponent();
        }

        private void CF_800_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                FillAreaUnitCombo();
                FillDWGNo();
                Fill_txtReportNumber();
                //var documentStatus = "OnCreating";
                //GenerateBarCode(documentStatus);  
                //InitComboCompany();


            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        

        private void SaveItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Msg.Show("Worked CRF 800 Click Save Form!");
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
                var data = CommonDals.Do.AreaUnit.FetchAreaUnitCombo(LoginInfo.ProjectId);
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
                //var employerId = Convert.ToInt32((this.OwnerView as frmCF).cmbCompany.GetColumnValue("EmployerId"));
                //var employer = Convert.ToInt32((this.OwnerView as frmCF).cmbCompany.GetColumnValue("Employer"));
                //var companyId = Convert.ToInt32((this.OwnerView as frmCF).cmbCompany.GetColumnValue("ContractorId"));
                //var UnitNo = 1;
                //var reportSyntax = "{[Employer]}," + employer + "#{[CFType]},(CF-819-1)#{[UnitNo]}," + UnitNo;
                //var report = DMS.ReportNumber.Do.Generate("QCEL", LoginInfo.ProjectId, disciplineId, null, companyId, reportSyntax);
                ReportNumberViewModel rnvm = new ReportNumberViewModel
                {
                    //ReportNumber = report.ReportNumber,
                    //CounterId = report.CounterId
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

                //DMS.Attachment.Do.AddAttachmentToGrid(fileAttachmentList, grcAttaochment, txtFileAttachPath.Text, LoginInfo.FullName, txtRemarkAttachment.Text.Trim(), this.Name)
                   // .HideColumns("Id,FilePath,FileTableName,CustomType,FileName");
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
                DMS.Attachment.Do.ShowAttachment(e, grcAttaochment, GlobaConfig.AttachmentDumpAddress);
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
                if (FormMode == FormState.View) return;
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

        private void CF_819_1_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage.AddSignPostActionTool(this);
                e.RibbonPage.AddSignAcceptActionTool(this);
                e.RibbonPage.AddSignRejectActionTool(this);
                e.RibbonPage.AddSignSendBackActionTool(this);
                e.RibbonPage.AddLiteGridTools(this);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Override Forms Actions Item Click events














    }
}
