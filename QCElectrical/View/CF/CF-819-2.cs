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
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISNewSecurity;
using QCElectrical.Infrastructure;
using DevExpress.XtraBars;

namespace QCElectrical.View.CF
{
    public partial class CF_819_2 : ViewTabWithCompany
    {
        BarItem newMenu;
        BarItem saveMenu;
        BarItem editMenu;
        BarItem deleteMenu;


        private int cfId = 0;
        private int documentId = 0;

        private List<FileAttachmentViewModel> fileAttachments = new List<FileAttachmentViewModel>();

        public CF_819_2()
        {
            InitializeComponent();
            ViewTitle = "CF-819-2 TRENCH COV.";
            FormMode = FormState.Save;
        }

        public CF_819_2(int documentId,int cfId, FormState formState)
        {
            InitializeComponent();
            ViewTitle = "CF-819-2 TRENCH COV.";

            FormMode = formState;
            this.documentId = documentId;
            this.cfId = cfId;
        }

        //BeforeViewLoad event
        private void CF_819_2_BeforeViewLoad(object sender, EventArgs e)
        {
            OnInit();//Set form as OnInitState
        }

        //Viewloaded event
        private void CF_819_2_ViewLoaded(object sender, EventArgs e)
        {           
            if (FormMode == FormState.View)
                OnViewState(this.documentId);

            if (FormMode == FormState.Save)
                OnSaveState();

            if (FormMode == FormState.Edit)
                OnEditState(this.documentId);
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
                if(FormMode==FormState.Save)
                    txtReportNo.Text = GenerateReportNumber();                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        // Handle form ribbon menu items
        private void CF_819_2_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                //e.RibbonPage
                //    .AddNewFormActionTool(this)// New
                //    .AddSaveFormActionTool(this)//Save menu in ribbon
                //    .AddEditFormActionTool(this)//Edit menu in ribbon
                //    .AddDeleteFormActionTool(this)//Delete menu in ribbon
                //    .AddSignPostActionTool(this)//Post Sign menu in ribbon
                //    .AddSignAcceptActionTool(this)//Accept SignMenu in ribbon
                //    .AddSignRejectActionTool(this)//Reject sign menu in ribbon
                //    .AddSignSendBackActionTool(this)//Senback sign menu in ribbon
                //    .AddSignReopenActionTool(this)//Reopen sign menu in ribbon
                //    .AddSignHistoryActionTool(this)//SignHistory tools in ribbon
                //    .AddAttachmentActionTool(this);//Attachment document tools in ribbon

                var items = MenuItems;

                newMenu = MenuItems["new"];//Get new menu object
                saveMenu = MenuItems["save"];//Get save menu object
                editMenu = MenuItems["edit"];//Get edit menu object
                deleteMenu = MenuItems["delete"];//get delete menu object

                newMenu.ItemClick += NewMenu_ItemClick; ;//Event for handle new menu item clicking
                saveMenu.ItemClick += SaveMenu_ItemClick;//Event for handle save menu item clicking
                deleteMenu.ItemClick += DeleteMenu_ItemClick;//Event for handle delete menu item clicking;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //Delete menu event
        private void DeleteMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormMode == FormState.Save) return;

                //Get cf selected row from the database by documentId
                var cfRow = DAL.Do.FetchCF_819(this.documentId,CFType.CF_819_2);

                //Get some data from cfRow
                var cfId = cfRow.ToInt("CfId");
                var data = DAL.Do.FetchCFItems(CFType.CF_819_2, cfId);

                //get document status
                var posted = cfRow.Posted();
                var isDelete = cfRow.IsDelete();
                var isVoid = cfRow.IsVoid();
                var reportNo = cfRow.ReportNo();

                //Check document status before delete
                if (isDelete) throw new CMISException("Document already deleted!");
                if (isVoid) throw new CMISException("Document is voided!");
                if (posted) throw new CMISException("Document is posted!");

                // if abov condition is pass then exceute bellow code and delete document
                var dialogResult = Msg.Confirm($"Are you sure to delete the {reportNo} cf document");
                if (dialogResult == DialogResult.No) return;
                // Delete start
                var result = DAL.Do.DeleteCFDocument(this.documentId,LoginInfo.Id);
                if (result > 0) Msg.Show("Operation delete successfull!");
                else Msg.Error("Operation delete faild!");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        // set for to new save state
        private void NewMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnSaveState();
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
                var attachmentDialogForm= CMISUI.UIHandler.ViewInNormalForm<Attachment.AttachmentUploader>(null);
                if(attachmentDialogForm.OwnerForm.DialogResult == DialogResult.OK)
                {
                    var filePath = attachmentDialogForm.FilePath;
                    var remark = attachmentDialogForm.Remark;
                    var customType = "CF-819-2";
                    var fileName = Guid.NewGuid().ToString();
                    // get attachments for selected cf  
                    DMS.Attachment.Do.AddAttachmentToGrid(fileAttachments, grcAttachment, filePath, LoginInfo.FullName, fileName, remark, customType, Bundle.SCHEMA, "View").UnEditableColumns().HideColumns("");
                }          
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
                if (FormMode == FormState.View) return;
                DMS.Attachment.Do.ClearAttachmentFromGrid(grcAttachment, fileAttachments);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        #region FormActions  
        //Validation form befor save
        private void ValidationForm()
        {
            if (String.IsNullOrEmpty(txtReportNo.Text)) throw new CMISException("Report number field required");
            if (String.IsNullOrEmpty(cmbUnit.Text)) throw new CMISException("Area/Unit field is required");
            if (String.IsNullOrEmpty(cmbDwgNo.Text)) throw new CMISException("DWGNo field is requirdred");
            if (String.IsNullOrEmpty(txtRevisionNo.Text)) throw new CMISException("RevisionNo field is required");
            if (String.IsNullOrEmpty(txtSubContractor.Text)) throw new CMISException("SubContractor field is required");
            if (String.IsNullOrEmpty(txtLocation.Text)) throw new CMISException("Location field is required");
            if (grvAttachment.RowCount <= 0) throw new CMISException("Attechment is required");
        }

        // Save action
        private void SaveMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Msg.Confirm("Are you sure to save cf document?") == DialogResult.No) return;

                //Validation Form
                ValidationForm();

                // Get form data 
                int employerId = Convert.ToInt32(cmbCompany.GetColumnValue("EmployerId"));
                int contractId = Convert.ToInt32(cmbCompany.GetColumnValue("Id"));
                int contractorId = Convert.ToInt32(cmbCompany.GetColumnValue("ContractorId"));
                int unitId = Convert.ToInt32(cmbUnit.GetColumnValue("Id"));
                var revisionId = Convert.ToInt32(cmbDwgNo.GetColumnValue("RevisionId"));
                string remark = txtRemark.Text;
                string revisionNo = txtRevisionNo.Text;
                string location = txtLocation.Text;
                int voltageCableType = Convert.ToInt32(rdgVoltageType.EditValue);
               
                //ReportNo
                var employer = Convert.ToString(cmbCompany.GetColumnValue("EmployerSymbol"));
                var UnitNo = Convert.ToString(cmbUnit.GetColumnValue("UnitName"));
                var reportParameters = "{[EmployerSymbol]}," + employer + "#{[CFType]},(CF-819-2)#{[UnitNo]}," + UnitNo;

                var roleOrder = 1;
                // Appear tvp attachments
                var attachments = fileAttachments.MapToTvpAttachment();
                var list = grvItems.GetDataTable().ToList<CFItem>();
                var itemsResult = list.Where(x=>!(x.ACC == false && x.REJ == false && x.NA == false))
                    .Select(x => new ItemResult
                    {
                        Id = x.Id,
                        ItemId = x.ItemId,
                        RoleOrder = roleOrder,
                        ItemValue = x.ItemValue
                    }).ToDataTable();

                var result = DAL.Do.SaveCF_WithFixedItems(cfId, LoginInfo.ProjectId, employerId, contractId, contractorId, LoginInfo.Id, Bundle.SCHEMA,
                    CFType.CF_819_2, revisionId, unitId, remark, revisionNo, location, voltageCableType, reportParameters, attachments, itemsResult);

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
            //Generate ReportNumber
            if (FormMode == FormState.Save) txtReportNo.Text = GenerateReportNumber();
        }
        #endregion


        #region Form States 
        //ViewSatate helper
        private void OnViewState(int documentId)
        {
            // Set form to view mode ui
            formStateControl.SetViewMode();

            //SetReadOnly
            grcAttachment.UnEditableColumns();
            btnAddAttachment.Enabled = false;
            btnDeleteAttachment.Enabled = false;      

            //Get cf selected row from the database by documentId
            var cfRow = DAL.Do.FetchCF_819(documentId, CFType.CF_819_2);

            //Get some data from cfRow
            var cfId = cfRow.ToInt("CfId");
            var data = DAL.Do.FetchCFItems(CFType.CF_819_2, cfId);
            //fill Cf Grid items
            FillCFItemsGrid(data);

            //Get some data from cfRow
            var projectId = cfRow.ProjectId();
            var objectId = cfRow.DocumentId();
            var objectName = cfRow.ObjectName();

            // Load attachments and fill to grid
            grcAttachment.DataSource = DAL.Do.FetchAttachments(objectId);
            grcAttachment.HideColumns("Id,IsUsed,FileTableName").UnEditableColumns();

            if (!cfRow.Posted())
            {
                formStateControl.ShowDraft();
                this.RibbonPage.Text = this.ViewTitle += " ::: DRAFT";
            }
            else formStateControl.HideDraft();

            //Set fields data
            cmbCompany.EditValue = cfRow.ContractId();
            txtReportNo.Text = cfRow.ReportNo();            
            cmbUnit.EditValue = cfRow.UnitId();
            cmbDwgNo.EditValue = cfRow.RevisionId();
            txtLocation.Text = cfRow.ToString("Location");
            rdgVoltageType.EditValue = cfRow.ToInt("VoltageCableType");

            cmbCompany.ReadOnly = true;
            cmbDwgNo.ReadOnly = true;
            txtLocation.ReadOnly = true;
            cmbUnit.ReadOnly = true;
            rdgVoltageType.ReadOnly = true;

        }
        // EditState helper
        private void OnEditState(int documentId)
        {
            // Set form to view mode ui
            formStateControl.SetEditMode();

            //SetReadOnly
            grcAttachment.UnEditableColumns();
            btnAddAttachment.Enabled = true;
            btnDeleteAttachment.Enabled = true;

            //Get cf selected row from the database by documentId
            var cfRow = DAL.Do.FetchCF_819(documentId, CFType.CF_819_2);
       
            //Get some data from cfRow
            var cfId = cfRow.ToInt("CfId");
            var data = DAL.Do.FetchCFItems(CFType.CF_819_2, cfId);
            //fill Cf Grid items
            FillCFItemsGrid(data);

            //Get some data from cfRow
            var projectId = cfRow.ProjectId();
            var objectId = cfRow.DocumentId();
            var objectName = cfRow.ObjectName();

            // Load attachments and fill to grid
            var attachments = DAL.Do.FetchAttachments(objectId);
            grcAttachment.DataSource = attachments;
            fileAttachments = attachments.ToList<FileAttachmentViewModel>();
            grcAttachment.HideColumns("").UnEditableColumns();

            if (!cfRow.Posted())
            {
                formStateControl.ShowDraft();
                this.RibbonPage.Text = this.ViewTitle += " ::: DRAFT";
            }
            else formStateControl.HideDraft();

            //Set fields data
            cmbCompany.EditValue = cfRow.ContractId();
            txtReportNo.Text = cfRow.ReportNo();
            cmbUnit.EditValue = cfRow.UnitId();
            cmbDwgNo.EditValue = cfRow.RevisionId();
            txtLocation.Text = cfRow.ToString("Location");
            rdgVoltageType.EditValue = cfRow.ToInt("VoltageCableType");

            cmbCompany.ReadOnly = true;
            cmbDwgNo.ReadOnly = true;
            txtLocation.ReadOnly = false;
            cmbUnit.ReadOnly = true;
            rdgVoltageType.ReadOnly = false;

            saveMenu.Enabled = true;
        }
        #endregion

        #region SaveState
        private void OnSaveState()
        {
            // Set form to view mode ui
            formStateControl.SetSaveMode();
            formStateControl.ShowDraft();

            formStateControl.ShowDraft();
            this.RibbonPage.Text = this.ViewTitle += " ::: DRAFT";        

            var data = DAL.Do.FetchCFItems(CFType.CF_819_2);
            FillCFItemsGrid(data);
        }
        #endregion

        //Regenerate report number by changing unit number
        private void cmbUnit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(FormMode == FormState.Save)
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
                cmbDwgNo.Fill(data, "DWGNo", "RevisionId");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
        // Fill CF Items Grid Helper
        private void FillCFItemsGrid(object data)
        {
            try
            {               
                grcItems.DataSource = data;
                grcItems.HideColumns("Id,ItemId,ItemValue").UnEditableColumns();                           

                if (FormMode != FormState.View)
                    grcItems.EditableColumns("ACC,REJ,NA");
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

                //set btnAcc and Rej and Na
                btnAcceptAll.Enabled = FormMode != FormState.View;
                btnRejectAll.Enabled = FormMode != FormState.View;
                btnNoAnswerAll.Enabled = FormMode != FormState.View;
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
                var reportSyntax = "{[EmployerSymbol]}," + employer + "#{[CFType]},(CF-819-2)#{[UnitNo]}," + UnitNo;
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



        private void grvItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DataTables.Init3ColumnItemAnsResult(sender as GridView, e.Column.FieldName, e.RowHandle);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        int toggleACC = 0;
        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            try
            {
                toggleREJ = toggleNA = 0;
                if (grvItems.SelectionInvalid()) return;
                if (toggleACC == 0) toggleACC = 1; else toggleACC = 0;
                for (int i = 0; i < grvItems.RowCount; i++)
                {
                    grvItems.SetRowCellValue(i, "ACC", toggleACC);
                    DataTables.Init3ColumnItemAnsResult(grvItems, "ACC", i);
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        int toggleREJ = 0;
        private void btnRejectAll_Click(object sender, EventArgs e)
        {
            try
            {
                toggleACC = toggleNA = 0;
                if (grvItems.SelectionInvalid()) return;
                if (toggleREJ == 0) toggleREJ = 1; else toggleREJ = 0;
                for (int i = 0; i < grvItems.RowCount; i++)
                {
                    grvItems.SetRowCellValue(i, "REJ", toggleREJ);
                    DataTables.Init3ColumnItemAnsResult(grvItems, "REJ", i);
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        int toggleNA = 0;
        private void btnNoAnswerAll_Click(object sender, EventArgs e)
        {
            try
            {
                toggleACC = toggleREJ = 0;
                if (grvItems.SelectionInvalid()) return;
                if (toggleNA == 0) toggleNA = 1; else toggleNA = 0;
                for (int i = 0; i < grvItems.RowCount; i++)
                {
                    grvItems.SetRowCellValue(i, "NA", toggleNA);
                    DataTables.Init3ColumnItemAnsResult(grvItems, "NA", i);
                }
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
