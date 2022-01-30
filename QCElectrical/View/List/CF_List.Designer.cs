namespace QCElectrical.View.List
{
    partial class CF_List
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
            this.grcCF = new CMISControls.Grid.CMGridControl();
            this.grvCF = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCF)).BeginInit();
            this.SuspendLayout();
            // 
            // grcCF
            // 
            this.grcCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCF.LoadingColor = System.Drawing.Color.Black;
            this.grcCF.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcCF.Location = new System.Drawing.Point(0, 0);
            this.grcCF.MainView = this.grvCF;
            this.grcCF.Name = "grcCF";
            this.grcCF.Size = new System.Drawing.Size(1354, 803);
            this.grcCF.TabIndex = 0;
            this.grcCF.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCF});
            // 
            // grvCF
            // 
            this.grvCF.GridControl = this.grcCF;
            this.grvCF.Name = "grvCF";
            this.grvCF.OptionsBehavior.Editable = false;
            this.grvCF.OptionsView.ShowAutoFilterRow = true;
            this.grvCF.OptionsView.ShowFooter = true;
            // 
            // CF_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcCF);
            this.Name = "CF_List";
            this.Size = new System.Drawing.Size(1354, 803);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.CF_List_RibbonPageAdded);
            this.ViewLoaded += new System.EventHandler(this.CF_List_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.CF_List_ViewRefresh);
            ((System.ComponentModel.ISupportInitialize)(this.grcCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcCF;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCF;
    }
}
