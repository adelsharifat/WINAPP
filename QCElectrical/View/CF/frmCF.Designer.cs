namespace QCElectrical.View.CF
{
    partial class frmCF
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCF = new CMISControls.Combo.CMLookupEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCFFullName = new System.Windows.Forms.Label();
            this.lblFormState = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            this.pnlCompanyCombo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCF.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgvMain
            // 
            this.pgvMain.Size = new System.Drawing.Size(1234, 733);
            // 
            // BorderBotttom
            // 
            this.BorderBotttom.Size = new System.Drawing.Size(1234, 1);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Size = new System.Drawing.Size(445, 26);
            // 
            // pnlCompanyCombo
            // 
            this.pnlCompanyCombo.Controls.Add(this.flowLayoutPanel1);
            this.pnlCompanyCombo.Controls.Add(this.cmbCF);
            this.pnlCompanyCombo.Controls.Add(this.label6);
            this.pnlCompanyCombo.Size = new System.Drawing.Size(1234, 51);
            this.pnlCompanyCombo.Controls.SetChildIndex(this.label6, 0);
            this.pnlCompanyCombo.Controls.SetChildIndex(this.cmbCF, 0);
            this.pnlCompanyCombo.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.pnlCompanyCombo.Controls.SetChildIndex(this.panel1, 0);
            this.pnlCompanyCombo.Controls.SetChildIndex(this.BorderBotttom, 0);
            // 
            // label1
            // 
            this.label1.Text = "Contract";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(637, 3);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "CF";
            // 
            // cmbCF
            // 
            this.cmbCF.Location = new System.Drawing.Point(44, 15);
            this.cmbCF.Name = "cmbCF";
            this.cmbCF.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCF.Properties.Appearance.Options.UseFont = true;
            this.cmbCF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCF.Properties.NullText = "-";
            this.cmbCF.Size = new System.Drawing.Size(215, 22);
            this.cmbCF.TabIndex = 10;
            this.cmbCF.EditValueChanged += new System.EventHandler(this.cmbCF_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "CF";
            // 
            // lblCFFullName
            // 
            this.lblCFFullName.AutoSize = true;
            this.lblCFFullName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCFFullName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFFullName.ForeColor = System.Drawing.Color.Black;
            this.lblCFFullName.Location = new System.Drawing.Point(3, 0);
            this.lblCFFullName.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblCFFullName.Name = "lblCFFullName";
            this.lblCFFullName.Padding = new System.Windows.Forms.Padding(5, 3, 5, 4);
            this.lblCFFullName.Size = new System.Drawing.Size(21, 22);
            this.lblCFFullName.TabIndex = 12;
            this.lblCFFullName.Text = "-";
            this.lblCFFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormState
            // 
            this.lblFormState.AutoSize = true;
            this.lblFormState.BackColor = System.Drawing.Color.ForestGreen;
            this.lblFormState.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormState.ForeColor = System.Drawing.Color.White;
            this.lblFormState.Location = new System.Drawing.Point(37, 0);
            this.lblFormState.Name = "lblFormState";
            this.lblFormState.Padding = new System.Windows.Forms.Padding(15, 3, 15, 4);
            this.lblFormState.Size = new System.Drawing.Size(41, 22);
            this.lblFormState.TabIndex = 13;
            this.lblFormState.Text = "-";
            this.lblFormState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCFFullName);
            this.flowLayoutPanel1.Controls.Add(this.lblFormState);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(265, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 24);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // frmCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmCF";
            this.Size = new System.Drawing.Size(1234, 784);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.frmCF_RibbonPageAdded);
            this.Load += new System.EventHandler(this.frmCF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            this.pnlCompanyCombo.ResumeLayout(false);
            this.pnlCompanyCombo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCF.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCFFullName;
        private System.Windows.Forms.Label lblFormState;
        public CMISControls.Combo.CMLookupEdit cmbCF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
