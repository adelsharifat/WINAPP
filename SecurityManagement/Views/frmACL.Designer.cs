
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
            this.grcACL = new DevExpress.XtraGrid.GridControl();
            this.grvACL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboProject = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcACL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvACL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcACL
            // 
            this.grcACL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcACL.Location = new System.Drawing.Point(0, 95);
            this.grcACL.MainView = this.grvACL;
            this.grcACL.Name = "grcACL";
            this.grcACL.Size = new System.Drawing.Size(1096, 634);
            this.grcACL.TabIndex = 0;
            this.grcACL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvACL});
            // 
            // grvACL
            // 
            this.grvACL.GridControl = this.grcACL;
            this.grvACL.Name = "grvACL";
            // 
            // cboProject
            // 
            this.cboProject.Location = new System.Drawing.Point(136, 33);
            this.cboProject.Name = "cboProject";
            this.cboProject.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboProject.Properties.Appearance.Options.UseFont = true;
            this.cboProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProject.Size = new System.Drawing.Size(217, 28);
            this.cboProject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project";
            // 
            // frmACL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.grcACL);
            this.Name = "frmACL";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1096, 729);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewBase.RibbonPageEventHandler(this.frmACL_RibbonPageAdded);
            ((System.ComponentModel.ISupportInitialize)(this.grcACL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvACL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcACL;
        private DevExpress.XtraGrid.Views.Grid.GridView grvACL;
        private DevExpress.XtraEditors.LookUpEdit cboProject;
        private System.Windows.Forms.Label label1;
    }
}
