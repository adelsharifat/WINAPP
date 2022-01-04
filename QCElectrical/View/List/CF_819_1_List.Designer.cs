namespace QCElectrical.View.List
{
    partial class CF_819_1_List
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
            this.grcCF_819_1 = new CMISControls.Grid.CMGridControl();
            this.grv_819_1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcCF_819_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_819_1)).BeginInit();
            this.SuspendLayout();
            // 
            // grcCF_819_1
            // 
            this.grcCF_819_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCF_819_1.LoadingColor = System.Drawing.Color.Black;
            this.grcCF_819_1.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcCF_819_1.Location = new System.Drawing.Point(0, 0);
            this.grcCF_819_1.MainView = this.grv_819_1;
            this.grcCF_819_1.Name = "grcCF_819_1";
            this.grcCF_819_1.Size = new System.Drawing.Size(1354, 803);
            this.grcCF_819_1.TabIndex = 0;
            this.grcCF_819_1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_819_1});
            // 
            // grv_819_1
            // 
            this.grv_819_1.GridControl = this.grcCF_819_1;
            this.grv_819_1.Name = "grv_819_1";
            this.grv_819_1.OptionsBehavior.Editable = false;
            // 
            // CF_819_1_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcCF_819_1);
            this.Name = "CF_819_1_List";
            this.Size = new System.Drawing.Size(1354, 803);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.CF_819_1_List_RibbonPageAdded);
            this.ViewLoaded += new System.EventHandler(this.CF_819_1_List_ViewLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.grcCF_819_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_819_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcCF_819_1;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_819_1;
    }
}
