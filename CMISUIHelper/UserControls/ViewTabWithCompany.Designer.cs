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
            this.cmbCompany = new CMISControls.Combo.CMLookupEdit();
            this.pnlCompanyCombo = new System.Windows.Forms.Panel();
            this.BorderBotttom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            this.pnlCompanyCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompany.Location = new System.Drawing.Point(652, 13);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompany.Size = new System.Drawing.Size(442, 26);
            this.cmbCompany.TabIndex = 0;
            // 
            // pnlCompanyCombo
            // 
            this.pnlCompanyCombo.Controls.Add(this.label1);
            this.pnlCompanyCombo.Controls.Add(this.cmbCompany);
            this.pnlCompanyCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompanyCombo.Location = new System.Drawing.Point(0, 0);
            this.pnlCompanyCombo.Name = "pnlCompanyCombo";
            this.pnlCompanyCombo.Size = new System.Drawing.Size(1107, 51);
            this.pnlCompanyCombo.TabIndex = 0;
            // 
            // BorderBotttom
            // 
            this.BorderBotttom.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderBotttom.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderBotttom.Location = new System.Drawing.Point(0, 51);
            this.BorderBotttom.Name = "BorderBotttom";
            this.BorderBotttom.Size = new System.Drawing.Size(1107, 1);
            this.BorderBotttom.TabIndex = 1;
            // 
            // CMISView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BorderBotttom);
            this.Controls.Add(this.pnlCompanyCombo);
            this.Name = "ViewTabWithCompany";
            this.Size = new System.Drawing.Size(1107, 759);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            this.pnlCompanyCombo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CMISControls.Combo.CMLookupEdit cmbCompany;
        private System.Windows.Forms.Panel pnlCompanyCombo;
        private System.Windows.Forms.Panel BorderBotttom;
    }
}
