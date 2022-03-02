
using System.Threading.Tasks;

namespace SecurityManagement.Views
{
    partial class frmUserPermision
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
            this.grcUserPermision = new CMISControls.Grid.CMGridControl();
            this.grvUserPermision = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcUserPermision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserPermision)).BeginInit();
            this.SuspendLayout();
            // 
            // grcUserPermision
            // 
            this.grcUserPermision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcUserPermision.LoadingColor = System.Drawing.Color.Black;
            this.grcUserPermision.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcUserPermision.Location = new System.Drawing.Point(0, 0);
            this.grcUserPermision.MainView = this.grvUserPermision;
            this.grcUserPermision.Name = "grcUserPermision";
            this.grcUserPermision.Size = new System.Drawing.Size(1178, 797);
            this.grcUserPermision.TabIndex = 0;
            this.grcUserPermision.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUserPermision});
            this.grcUserPermision.DataLoaded += new System.EventHandler(this.grcUserPermision_DataLoaded);
            // 
            // grvUserPermision
            // 
            this.grvUserPermision.GridControl = this.grcUserPermision;
            this.grvUserPermision.Name = "grvUserPermision";
            this.grvUserPermision.OptionsBehavior.Editable = false;
            this.grvUserPermision.OptionsView.ShowAutoFilterRow = true;
            this.grvUserPermision.OptionsView.ShowFooter = true;
            this.grvUserPermision.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvUserPermision_RowCellClick);
            this.grvUserPermision.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grvUserPermision_MouseMove);
            // 
            // frmUserPermision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcUserPermision);
            this.Name = "frmUserPermision";
            this.Size = new System.Drawing.Size(1178, 797);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.frmUserPermision_RibbonPageAdded);
            this.ViewLoaded += new System.EventHandler(this.frmUserPermision_ViewLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.grcUserPermision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserPermision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcUserPermision;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUserPermision;
    }
}
