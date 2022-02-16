namespace Electrical.View
{
    partial class Category
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSubCategory = new DevExpress.XtraEditors.TextEdit();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.treeCategory = new DevExpress.XtraTreeList.TreeList();
            this.cboTreeCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cboTreeCategory);
            this.pnlTop.Controls.Add(this.cboCategory);
            this.pnlTop.Controls.Add(this.lblCategory);
            this.pnlTop.Controls.Add(this.txtSubCategory);
            this.pnlTop.Controls.Add(this.lblSubCategory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1257, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(482, 39);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.Properties.Appearance.Options.UseFont = true;
            this.cboCategory.Properties.Appearance.Options.UseForeColor = true;
            this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategory.Properties.NullText = "Choose Category";
            this.cboCategory.Size = new System.Drawing.Size(253, 24);
            this.cboCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(404, 42);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category ::";
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(138, 39);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategory.Properties.Appearance.Options.UseFont = true;
            this.txtSubCategory.Size = new System.Drawing.Size(240, 24);
            this.txtSubCategory.TabIndex = 3;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.Location = new System.Drawing.Point(38, 42);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(94, 17);
            this.lblSubCategory.TabIndex = 2;
            this.lblSubCategory.Text = "SubCategory ::";
            // 
            // treeCategory
            // 
            this.treeCategory.ColumnPanelRowHeight = 25;
            this.treeCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCategory.Location = new System.Drawing.Point(0, 100);
            this.treeCategory.Name = "treeCategory";
            this.treeCategory.OptionsBehavior.Editable = false;
            this.treeCategory.OptionsView.ShowAutoFilterRow = true;
            this.treeCategory.OptionsView.ShowSummaryFooter = true;
            this.treeCategory.Size = new System.Drawing.Size(1257, 691);
            this.treeCategory.TabIndex = 1;
            // 
            // cboTreeCategory
            // 
            this.cboTreeCategory.Location = new System.Drawing.Point(849, 37);
            this.cboTreeCategory.Name = "cboTreeCategory";
            this.cboTreeCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTreeCategory.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboTreeCategory.Properties.Appearance.Options.UseFont = true;
            this.cboTreeCategory.Properties.Appearance.Options.UseForeColor = true;
            this.cboTreeCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTreeCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.cboTreeCategory.Size = new System.Drawing.Size(197, 26);
            this.cboTreeCategory.TabIndex = 7;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category ::";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeCategory);
            this.Controls.Add(this.pnlTop);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(1257, 791);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.Category_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.Category_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.Category_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.Category_ViewRefresh);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCategory;
        private DevExpress.XtraEditors.TextEdit txtSubCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private DevExpress.XtraEditors.LookUpEdit cboCategory;
        private DevExpress.XtraTreeList.TreeList treeCategory;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TreeListLookUpEdit cboTreeCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
    }
}
