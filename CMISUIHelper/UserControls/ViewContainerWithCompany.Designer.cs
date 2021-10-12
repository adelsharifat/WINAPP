namespace CMISUIHelper.UserControls
{
    partial class ViewContainerWithCompany
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
            this.pgvMain = new CMISUIHelper.UserControls.PageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            this.pnlCompanyCombo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderBotttom
            // 
            this.BorderBotttom.Size = new System.Drawing.Size(1245, 1);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            // 
            // pnlCompanyCombo
            // 
            this.pnlCompanyCombo.Size = new System.Drawing.Size(1245, 51);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(765, 2);
            // 
            // pgvMain
            // 
            this.pgvMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.pgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgvMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pgvMain.ItemSize = new System.Drawing.Size(0, 1);
            this.pgvMain.Location = new System.Drawing.Point(0, 51);
            this.pgvMain.Name = "pgvMain";
            this.pgvMain.Padding = new System.Drawing.Point(0, 0);
            this.pgvMain.SelectedIndex = 0;
            this.pgvMain.Size = new System.Drawing.Size(1245, 769);
            this.pgvMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pgvMain.TabIndex = 1;
            // 
            // ViewContainerWithCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pgvMain);
            this.Name = "ViewContainerWithCompany";
            this.Size = new System.Drawing.Size(1245, 820);
            this.Controls.SetChildIndex(this.pnlCompanyCombo, 0);
            this.Controls.SetChildIndex(this.pgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            this.pnlCompanyCombo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public PageViewer pgvMain;
    }
}
