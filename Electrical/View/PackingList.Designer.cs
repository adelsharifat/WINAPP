namespace Electrical.View
{
    partial class PackingList
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
            this.grcPackingList = new CMISControls.Grid.CMGridControl();
            this.grvPackingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPackingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackingList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1377, 1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1377, 52);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.EditValueChanged += new System.EventHandler(this.cmbCompany_EditValueChanged);
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1377, 51);
            // 
            // grcPackingList
            // 
            this.grcPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPackingList.LoadingColor = System.Drawing.Color.Black;
            this.grcPackingList.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcPackingList.Location = new System.Drawing.Point(0, 52);
            this.grcPackingList.MainView = this.grvPackingList;
            this.grcPackingList.Name = "grcPackingList";
            this.grcPackingList.Size = new System.Drawing.Size(1377, 760);
            this.grcPackingList.TabIndex = 0;
            this.grcPackingList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPackingList});
            // 
            // grvPackingList
            // 
            this.grvPackingList.GridControl = this.grcPackingList;
            this.grvPackingList.Name = "grvPackingList";
            this.grvPackingList.OptionsBehavior.Editable = false;
            this.grvPackingList.OptionsView.ShowAutoFilterRow = true;
            this.grvPackingList.OptionsView.ShowFooter = true;
            // 
            // PackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcPackingList);
            this.Name = "PackingList";
            this.Size = new System.Drawing.Size(1377, 812);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.PackingList_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.PackingList_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.PackingList_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.PackingList_ViewRefresh);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.grcPackingList, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPackingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcPackingList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPackingList;
    }
}
