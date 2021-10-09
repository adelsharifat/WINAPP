namespace SecurityManagement.Views.CFForms
{
    partial class CF_801_1
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
            this.cmGridControl1 = new CMISControls.Grid.CMGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmGridControl1
            // 
            this.cmGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmGridControl1.LoadingColor = System.Drawing.Color.Black;
            this.cmGridControl1.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.cmGridControl1.Location = new System.Drawing.Point(0, 0);
            this.cmGridControl1.MainView = this.gridView1;
            this.cmGridControl1.Name = "cmGridControl1";
            this.cmGridControl1.Size = new System.Drawing.Size(1148, 728);
            this.cmGridControl1.TabIndex = 0;
            this.cmGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cmGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CF_801_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmGridControl1);
            this.Name = "CF_801_1";
            this.Size = new System.Drawing.Size(1148, 728);
            ((System.ComponentModel.ISupportInitialize)(this.cmGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl cmGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
