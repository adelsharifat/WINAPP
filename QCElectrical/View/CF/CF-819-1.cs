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
using CMISDAL.Common;
using CMISUtils;
using Security;
using CMISUIHelper.Infrastructure.Helpers;
using DevExpress.XtraEditors;
using QCElectrical.Data;
using DevExpress.XtraGrid.Columns;
using DMS.ViewModel;
using CMISUIHelper.Infrastructure.Enums;
using CMISBEL.Core.Common;
using DMS.Extentions;
using QCElectrical.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace QCElectrical.View.CF
{
    public partial class CF_819_1 : ViewTabWithCompany
    {
        private int cfId = 0;



        private List<FileAttachmentViewModel> fileAttachments = new List<FileAttachmentViewModel>();

        public CF_819_1()
        {
            InitializeComponent();
        }



        private void CF_819_1_ViewLoaded(object sender, EventArgs e)
        {
            OnInit();//Set form as OnInitState
        }

        //event change dwgNo set through revision
        private void cmbDwgNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtRevisionNo.Text = cmbDwgNo.GetColumnValue("RevNo").ToString();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //event change contract combo update subContractorField
        private void cmbCompany_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //fill subcontractor name by changing contract combo
                txtSubContractor.Text = cmbCompany.GetColumnValue("ContractorSymbol").ToString();
                //Regenerate report number by changing contract 
                txtReportNo.Text = GenerateReportNumber();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

  
        // Handle form ribbon menu items
        private void CF_819_1_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage
                    .AddSaveFormActionTool(this)//Save menu in ribbon
                    .AddEditFormActionTool(this)//Edit menu in ribbon
                    .AddDeleteFormActionTool(this);//Delete menu in ribbon

                var items = MenuItems;

                var saveMenu = MenuItems["save"];//Get save menu object
                var editMenu = MenuItems["edit"];//Get edit menu object
                var deleteMenu = MenuItems["delete"];//get delete menu object

                saveMenu.ItemClick += SaveMenu_ItemClick;//Event for handle save menu item clicking

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        

        //Event add attchment to grcAttachment grid
        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                var attachmentDialogForm= CMISUI.UIHandler.ViewInForm<Attachment.AttachmentUploader>(null,FormBorderStyle.FixedToolWindow);
                var filePath = attachmentDialogForm.FilePath;
                var remark = attachmentDialogForm.Remark;
                var customType = "CF-819-1";
                var fileName = Guid.NewGuid().ToString();

                DMS.Attachment.Do.AddAttachmentToGrid(fileAttachments, grcAttachment, filePath, LoginInfo.FullName,fileName, remark, customType,Bundle.SCHEMA,"View").UnEditableColumns().HideColumns("");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        //Event show attachment from grcAttachment grid
        private void grvAttachment_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DMS.Attachment.Do.ShowAttachment(e, grcAttachment, GlobaConfig.AttachmentDumpAddress);
            }
            catch (Exception ex)
            {

                ex.ShowMessage();
            }
        }
        //Delete attachment from grcAttachment grid
        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormMode == FormState.ReadMode) return;
                DMS.Attachment.Do.ClearAttachmentFromGrid(grcAttachment, fileAttachments);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }


        #region FormActions   
        // Save action
        private void SaveMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Validation Form Here



                int employerId = Convert.ToInt32(cmbCompany.GetColumnValue("EmployerId"));
                int contractId = Convert.ToInt32(cmbCompany.GetColumnValue("Id"));
                int contractorId = Convert.ToInt32(cmbCompany.GetColumnValue("ContractorId"));
                int unitId = Convert.ToInt32(cmbUnit.GetColumnValue("Id"));
                var dwgNo = Convert.ToString(cmbDwgNo.GetColumnValue("DWGNo"));
                string remark = txtRemark.Text;
                string revisionNo = txtRevisionNo.Text;
                string location = txtLocation.Text;
                int voltageCableType = Convert.ToInt32(rdgVoltageType.EditValue);
                //ReportNo
                var employer = Convert.ToString(cmbCompany.GetColumnValue("EmployerSymbol"));
                var UnitNo = Convert.ToString(cmbUnit.GetColumnValue("UnitName"));
                var reportParameters = "{[EmployerSymbol]}," + employer + "#{[CFType]},(CF-819-1)#{[UnitNo]}," + UnitNo;

                var roleOrder = 1;
                // Appear tvp attachments
                var attachments = fileAttachments.MapToTvpAttachment();
                var list = grvItems.GetDataTable().ToList<CFItem>();
                var itemsResult = list
                    .Select(x => new ItemResult
                    {
                        Id = x.ResultId,
                        ItemIdId = x.Id,
                        RoleOrder = roleOrder,
                        ItemValue = x.InspectionResult
                    }).ToDataTable();


                var result = DAL.Do.SaveCF_WithFixedItems(cfId, LoginInfo.ProjectId, employerId, contractId, contractorId, LoginInfo.Id, Bundle.SCHEMA,
                    "CF-801-19", dwgNo, unitId, remark, revisionNo, location, voltageCableType, reportParameters, attachments, itemsResult);

                if (result > 0)
                    Msg.Show("Operation Sucess!");
                else
                    Msg.Show("Operation Faild!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        



        #endregion






        #region InitialState
        private void OnInit()
        {
            InitComboCompany();
            //Call Fill Area Unit Combo
            FillAreaUnitCombo();
            //Call Fill DWG No Combo
            FillDWGNo();
            //Fill Grid Cf Items
            FillGrid();
            //Generate ReportNumber
            txtReportNo.Text = GenerateReportNumber();
        }
        #endregion


        #region ReadState 

        private void OnReadState()
        {

        }





        #endregion

        #region SaveState













        #endregion

        #region EditState

        #endregion

        #region DeleteState

        #endregion

        #region ResetFormState

        #endregion



        //Regenerate report number by changing unit number
        private void cmbUnit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtReportNo.Text = GenerateReportNumber();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        #region Helper
        // Fill DWG No Combo Helper
        private void FillDWGNo()
        {
            try
            {
                var data = CommonDals.Do.DWGNo.FetchDWGNo();
                cmbDwgNo.Fill(data, "DWGNo", "RevisionId").HideColumns("");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        // Fill CF Items Grid Helper
        private void FillGrid()
        {
            try
            {
                var data = DAL.Do.FetchCFItems("CF819-1");
                grcItems.DataSource = data;
                grcItems.HideColumns("Id").EditableColumns("ACC,REJ,NA");

                //get columns need set to editable
                var columnRowNumber = grvItems.Columns["RowNo"] as GridColumn;
                var columnName = grvItems.Columns["Name"] as GridColumn;
                var colACC = grvItems.Columns["ACC"] as GridColumn;
                var colREJ = grvItems.Columns["REJ"] as GridColumn;
                var colNA = grvItems.Columns["NA"] as GridColumn;
               
                // Set custom size for columns
                columnRowNumber.Width = colACC.Width = colREJ.Width = colNA.Width = 50;
                columnRowNumber.MaxWidth = colACC.MaxWidth = colREJ.MaxWidth = colNA.MaxWidth = 50;
                columnRowNumber.MinWidth = colACC.MinWidth = colREJ.MinWidth = colNA.MinWidth = 50;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        // Fill Area Unit Combo Helper
        private void FillAreaUnitCombo()
        {
            try
            {
                var data = CommonDals.Do.AreaUnit.FetchAreaUnitCombo(LoginInfo.ProjectId);
                cmbUnit.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("AreaId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        // Generate Report number Helper
        private string GenerateReportNumber()
        {
            try
            {
                var disciplineId = Convert.ToInt32(belConfig.Do.Config(LoginInfo.ProjectId, AppConst.ScopeInConfig)["DisciplineId"]);
                var employerId = Convert.ToInt32(cmbCompany.GetColumnValue("EmployerId"));
                var employer = Convert.ToString(cmbCompany.GetColumnValue("EmployerSymbol"));
                var companyId = Convert.ToInt32(cmbCompany.GetColumnValue("ContractorId"));
                var UnitNo = Convert.ToString(cmbUnit.GetColumnValue("UnitName"));
                var reportSyntax = "{[EmployerSymbol]}," + employer + "#{[CFType]},(CF-819-1)#{[UnitNo]}," + UnitNo;
                var report = DMS.ReportNumber.Do.Generate(Bundle.SCHEMA, LoginInfo.ProjectId, disciplineId, null, companyId, reportSyntax);
                return report.ReportNumber;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
                return null;
            }
        }
        #endregion

        #region Override Methosds
        public override void InitComboCompany()
        {
            var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
            this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
        }
        #endregion

        private void txtReportNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Update cf items where grid is null
                FillGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvItems_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var gridView = sender as GridView;
                Msg.Show(e.Column.Name);
                switch (e.Column.FieldName)
                {
                    case "ACC":
                        gridView.SetRowCellValue(e.RowHandle, "REJ", 0);
                        gridView.SetRowCellValue(e.RowHandle, "NA", 0);
                        break;
                    case "REJ":
                        gridView.SetRowCellValue(e.RowHandle, "ACC", 0);
                        gridView.SetRowCellValue(e.RowHandle, "NA", 0);
                        break;
                    case "NA":
                        gridView.SetRowCellValue(e.RowHandle, "ACC", 0);
                        gridView.SetRowCellValue(e.RowHandle, "REJ", 0);
                        break;
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void grvItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
  
        }

        private void grvItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = sender as GridView;
                switch (e.Column.FieldName)
                {
                    case "ACC":
                        gridView.SetRowCellValue(e.RowHandle, "REJ", 0);
                        gridView.SetRowCellValue(e.RowHandle, "NA", 0);
                        break;
                    case "REJ":
                        gridView.SetRowCellValue(e.RowHandle, "ACC", 0);
                        gridView.SetRowCellValue(e.RowHandle, "NA", 0);
                        break;
                    case "NA":
                        gridView.SetRowCellValue(e.RowHandle, "ACC", 0);
                        gridView.SetRowCellValue(e.RowHandle, "REJ", 0);
                        break;
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
