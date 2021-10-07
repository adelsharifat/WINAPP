
namespace SecurityManagement.Views
{
    partial class frmPermisionGroup
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
            this.grcPermisionGroup = new CMISControls.Grid.CMGridControl();
            this.grvPermisionGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProject = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPermisionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPermisionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcPermisionGroup
            // 
            this.grcPermisionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcPermisionGroup.LoadingColor = System.Drawing.Color.Black;
            this.grcPermisionGroup.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcPermisionGroup.Location = new System.Drawing.Point(0, 68);
            this.grcPermisionGroup.MainView = this.grvPermisionGroup;
            this.grcPermisionGroup.Name = "grcPermisionGroup";
            this.grcPermisionGroup.Size = new System.Drawing.Size(1100, 680);
            this.grcPermisionGroup.TabIndex = 1;
            this.grcPermisionGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPermisionGroup});
            this.grcPermisionGroup.DataLoaded += new System.EventHandler(this.grcPermisionGroup_DataLoaded);
            this.grcPermisionGroup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grvUserPermision_MouseMove);
            // 
            // grvPermisionGroup
            // 
            this.grvPermisionGroup.GridControl = this.grcPermisionGroup;
            this.grvPermisionGroup.Name = "grvPermisionGroup";
            this.grvPermisionGroup.OptionsBehavior.Editable = false;
            this.grvPermisionGroup.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvUserPermision_RowCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project ::";
            // 
            // cboProject
            // 
            this.cboProject.Location = new System.Drawing.Point(111, 20);
            this.cboProject.Name = "cboProject";
            this.cboProject.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboProject.Properties.Appearance.Options.UseFont = true;
            this.cboProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProject.Properties.NullText = "";
            this.cboProject.Size = new System.Drawing.Size(217, 28);
            this.cboProject.TabIndex = 4;
            this.cboProject.EditValueChanged += new System.EventHandler(this.cboProject_EditValueChanged);
            // 
            // frmPermisionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.grcPermisionGroup);
            this.Name = "frmPermisionGroup";
            this.Size = new System.Drawing.Size(1100, 748);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.frmPermisionGroup_RibbonPageAdded);
            this.ViewLoaded += new System.EventHandler(this.frmUserPermision_ViewLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.grcPermisionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPermisionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcPermisionGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPermisionGroup;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cboProject;
    }
}
