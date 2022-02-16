namespace Electrical.View
{
    partial class MIVList
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
            this.grcMIV = new CMISControls.Grid.CMGridControl();
            this.grvMIV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMIV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1382, 1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1382, 52);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Properties.EditValueChanged += new System.EventHandler(this.cmbCompany_Properties_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Text = "Contractor";
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1382, 51);
            // 
            // grcMIV
            // 
            this.grcMIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMIV.LoadingColor = System.Drawing.Color.Black;
            this.grcMIV.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcMIV.Location = new System.Drawing.Point(0, 52);
            this.grcMIV.MainView = this.grvMIV;
            this.grcMIV.Name = "grcMIV";
            this.grcMIV.Size = new System.Drawing.Size(1382, 736);
            this.grcMIV.TabIndex = 1;
            this.grcMIV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMIV});
            // 
            // grvMIV
            // 
            this.grvMIV.GridControl = this.grcMIV;
            this.grvMIV.Name = "grvMIV";
            this.grvMIV.OptionsBehavior.Editable = false;
            this.grvMIV.OptionsView.ShowAutoFilterRow = true;
            this.grvMIV.OptionsView.ShowFooter = true;
            // 
            // MIVList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcMIV);
            this.Name = "MIVList";
            this.Size = new System.Drawing.Size(1382, 788);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.MIVList_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.MIVList_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.MIVList_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.MIVList_ViewRefresh);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.grcMIV, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcMIV;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMIV;
    }
}
