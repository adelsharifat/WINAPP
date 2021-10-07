
namespace SecurityManagement.Views
{
    partial class frmACL
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmACL));
            this.cboProject = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExpandCollaps = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRecetACLList = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSaveAclData = new DevExpress.XtraEditors.SimpleButton();
            this.grcACL = new CMISControls.Grid.CMGridControl();
            this.grvACL = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcACL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvACL)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProject
            // 
            this.cboProject.Location = new System.Drawing.Point(109, 21);
            this.cboProject.Name = "cboProject";
            this.cboProject.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboProject.Properties.Appearance.Options.UseFont = true;
            this.cboProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProject.Properties.NullText = "";
            this.cboProject.Size = new System.Drawing.Size(217, 28);
            this.cboProject.TabIndex = 2;
            this.cboProject.EditValueChanged += new System.EventHandler(this.cboProject_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project ::";
            // 
            // BtnExpandCollaps
            // 
            this.BtnExpandCollaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExpandCollaps.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpandCollaps.Appearance.Options.UseFont = true;
            this.BtnExpandCollaps.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExpandCollaps.ImageOptions.Image")));
            this.BtnExpandCollaps.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnExpandCollaps.ImageOptions.ImageToTextIndent = -8;
            this.BtnExpandCollaps.Location = new System.Drawing.Point(737, 21);
            this.BtnExpandCollaps.Name = "BtnExpandCollaps";
            this.BtnExpandCollaps.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnExpandCollaps.Size = new System.Drawing.Size(100, 29);
            this.BtnExpandCollaps.TabIndex = 8;
            this.BtnExpandCollaps.Text = "Expand";
            this.BtnExpandCollaps.Click += new System.EventHandler(this.BtnExpandCollaps_Click);
            // 
            // BtnRecetACLList
            // 
            this.BtnRecetACLList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecetACLList.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecetACLList.Appearance.Options.UseFont = true;
            this.BtnRecetACLList.Location = new System.Drawing.Point(843, 21);
            this.BtnRecetACLList.Name = "BtnRecetACLList";
            this.BtnRecetACLList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnRecetACLList.Size = new System.Drawing.Size(114, 29);
            this.BtnRecetACLList.TabIndex = 7;
            this.BtnRecetACLList.Text = "Reset ACL";
            this.BtnRecetACLList.Click += new System.EventHandler(this.BtnResetAclList_Click);
            // 
            // BtnSaveAclData
            // 
            this.BtnSaveAclData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveAclData.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveAclData.Appearance.Options.UseFont = true;
            this.BtnSaveAclData.Location = new System.Drawing.Point(963, 21);
            this.BtnSaveAclData.Name = "BtnSaveAclData";
            this.BtnSaveAclData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnSaveAclData.Size = new System.Drawing.Size(106, 29);
            this.BtnSaveAclData.TabIndex = 6;
            this.BtnSaveAclData.Text = "Save";
            this.BtnSaveAclData.Click += new System.EventHandler(this.BtnSaveAclData_Click);
            // 
            // grcACL
            // 
            this.grcACL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcACL.LoadingColor = System.Drawing.Color.Black;
            this.grcACL.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcACL.Location = new System.Drawing.Point(0, 66);
            this.grcACL.MainView = this.grvACL;
            this.grcACL.Name = "grcACL";
            this.grcACL.Size = new System.Drawing.Size(1096, 663);
            this.grcACL.TabIndex = 9;
            this.grcACL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvACL});
            this.grcACL.DataLoaded += new System.EventHandler(this.grcACL_DataLoaded);
            // 
            // grvACL
            // 
            this.grvACL.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvACL.Appearance.GroupRow.Options.UseFont = true;
            this.grvACL.GridControl = this.grcACL;
            this.grvACL.GroupFormat = "{1}";
            this.grvACL.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
            this.grvACL.Name = "grvACL";
            this.grvACL.OptionsView.ShowFooter = true;
            this.grvACL.OptionsView.ShowGroupedColumns = true;
            this.grvACL.OptionsView.ShowGroupPanel = false;
            this.grvACL.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvACL_CustomRowCellEdit);
            this.grvACL.GroupRowExpanded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.grvACL_GroupRowExpanded);
            this.grvACL.GroupRowCollapsed += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.grvACL_GroupRowCollapsed);
            this.grvACL.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvACL_ShowingEditor);
            // 
            // frmACL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcACL);
            this.Controls.Add(this.BtnExpandCollaps);
            this.Controls.Add(this.BtnRecetACLList);
            this.Controls.Add(this.BtnSaveAclData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProject);
            this.Name = "frmACL";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1096, 729);
            this.ViewLoaded += new System.EventHandler(this.frmACL_ViewLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcACL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvACL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit cboProject;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnExpandCollaps;
        private DevExpress.XtraEditors.SimpleButton BtnRecetACLList;
        private DevExpress.XtraEditors.SimpleButton BtnSaveAclData;
        private CMISControls.Grid.CMGridControl grcACL;
        private DevExpress.XtraGrid.Views.Grid.GridView grvACL;
    }
}
