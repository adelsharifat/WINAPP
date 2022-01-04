namespace CMISUIHelper.UserControls
{
    partial class ViewTabWithCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeaderBottomSeperator = new System.Windows.Forms.Panel();
            this.pnlHeaderContainer = new System.Windows.Forms.Panel();
            this.cmbCompany = new CMISControls.Combo.CMLookupEdit();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlHeaderContainer);
            this.pnlHeader.Controls.Add(this.pnlHeaderBottomSeperator);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1379, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCompany);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(822, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.panel1.Size = new System.Drawing.Size(557, 51);
            this.panel1.TabIndex = 2;
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlHeaderBottomSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderBottomSeperator.Location = new System.Drawing.Point(0, 51);
            this.pnlHeaderBottomSeperator.Name = "pnlHeaderBottomSeperator";
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1379, 1);
            this.pnlHeaderBottomSeperator.TabIndex = 1;
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Controls.Add(this.panel1);
            this.pnlHeaderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderContainer.Name = "pnlHeaderContainer";
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1379, 51);
            this.pnlHeaderContainer.TabIndex = 3;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompany.Location = new System.Drawing.Point(107, 10);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCompany.Size = new System.Drawing.Size(442, 26);
            this.cmbCompany.TabIndex = 0;
            // 
            // ViewTabWithCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "ViewTabWithCompany";
            this.Size = new System.Drawing.Size(1379, 759);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHeaderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlHeaderBottomSeperator;
        public System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        public CMISControls.Combo.CMLookupEdit cmbCompany;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlHeaderContainer;
    }
}
