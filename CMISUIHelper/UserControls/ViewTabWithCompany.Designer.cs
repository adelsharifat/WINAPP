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
            this.pnlCompanyCombo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCompany = new CMISControls.Combo.CMLookupEdit();
            this.BorderBotttom = new System.Windows.Forms.Panel();
            this.pnlCompanyCombo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCompanyCombo
            // 
            this.pnlCompanyCombo.Controls.Add(this.panel1);
            this.pnlCompanyCombo.Controls.Add(this.BorderBotttom);
            this.pnlCompanyCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompanyCombo.Location = new System.Drawing.Point(0, 0);
            this.pnlCompanyCombo.Name = "pnlCompanyCombo";
            this.pnlCompanyCombo.Size = new System.Drawing.Size(1229, 51);
            this.pnlCompanyCombo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCompany);
            this.panel1.Location = new System.Drawing.Point(669, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 45);
            this.panel1.TabIndex = 2;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompany.Location = new System.Drawing.Point(107, 9);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCompany.Size = new System.Drawing.Size(444, 26);
            this.cmbCompany.TabIndex = 0;
            // 
            // BorderBotttom
            // 
            this.BorderBotttom.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderBotttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBotttom.Location = new System.Drawing.Point(0, 50);
            this.BorderBotttom.Name = "BorderBotttom";
            this.BorderBotttom.Size = new System.Drawing.Size(1229, 1);
            this.BorderBotttom.TabIndex = 1;
            // 
            // ViewTabWithCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCompanyCombo);
            this.Name = "ViewTabWithCompany";
            this.Size = new System.Drawing.Size(1229, 759);
            this.pnlCompanyCombo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel BorderBotttom;
        public CMISControls.Combo.CMLookupEdit cmbCompany;
        public System.Windows.Forms.Panel pnlCompanyCombo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
    }
}
