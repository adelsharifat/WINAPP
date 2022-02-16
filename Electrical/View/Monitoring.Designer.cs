namespace Electrical.View
{
    partial class Monitoring
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
            this.grcMonitoring = new CMISControls.Grid.CMGridControl();
            this.grvMonitoring = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMonitoring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonitoring)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1347, 1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1347, 52);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.Properties.Appearance.Options.UseForeColor = true;
            this.cmbCompany.EditValueChanged += new System.EventHandler(this.cmbCompany_EditValueChanged);
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1347, 51);
            // 
            // grcMonitoring
            // 
            this.grcMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMonitoring.LoadingColor = System.Drawing.Color.Black;
            this.grcMonitoring.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcMonitoring.Location = new System.Drawing.Point(0, 52);
            this.grcMonitoring.MainView = this.grvMonitoring;
            this.grcMonitoring.Name = "grcMonitoring";
            this.grcMonitoring.Size = new System.Drawing.Size(1347, 716);
            this.grcMonitoring.TabIndex = 1;
            this.grcMonitoring.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMonitoring});
            // 
            // grvMonitoring
            // 
            this.grvMonitoring.GridControl = this.grcMonitoring;
            this.grvMonitoring.Name = "grvMonitoring";
            this.grvMonitoring.OptionsBehavior.Editable = false;
            this.grvMonitoring.OptionsView.ShowAutoFilterRow = true;
            this.grvMonitoring.OptionsView.ShowFooter = true;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcMonitoring);
            this.Name = "Monitoring";
            this.Size = new System.Drawing.Size(1347, 768);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.Monitoring_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.Monitoring_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.Monitoring_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.Monitoring_ViewRefresh);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.grcMonitoring, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMonitoring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonitoring)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcMonitoring;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMonitoring;
    }
}
