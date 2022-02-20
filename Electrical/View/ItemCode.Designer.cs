namespace Electrical.View
{
    partial class ItemCode
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
            this.grcItemCode = new CMISControls.Grid.CMGridControl();
            this.grvItemCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTreeCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.cboWarehouseItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cboQtyUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItemCode)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouseItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtyUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcItemCode
            // 
            this.grcItemCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcItemCode.LoadingColor = System.Drawing.Color.Black;
            this.grcItemCode.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcItemCode.Location = new System.Drawing.Point(0, 148);
            this.grcItemCode.MainView = this.grvItemCode;
            this.grcItemCode.Name = "grcItemCode";
            this.grcItemCode.Size = new System.Drawing.Size(1249, 593);
            this.grcItemCode.TabIndex = 0;
            this.grcItemCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItemCode});
            // 
            // grvItemCode
            // 
            this.grvItemCode.GridControl = this.grcItemCode;
            this.grvItemCode.Name = "grvItemCode";
            this.grvItemCode.OptionsBehavior.Editable = false;
            this.grvItemCode.OptionsView.ShowAutoFilterRow = true;
            this.grvItemCode.OptionsView.ShowFooter = true;
            this.grvItemCode.DoubleClick += new System.EventHandler(this.gvItemCode_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.cboQtyUnit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboTreeCategory);
            this.panel1.Controls.Add(this.cboWarehouseItemCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.lblItemCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 148);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category ::";
            // 
            // cboTreeCategory
            // 
            this.cboTreeCategory.Location = new System.Drawing.Point(119, 63);
            this.cboTreeCategory.Name = "cboTreeCategory";
            this.cboTreeCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTreeCategory.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboTreeCategory.Properties.Appearance.Options.UseFont = true;
            this.cboTreeCategory.Properties.Appearance.Options.UseForeColor = true;
            this.cboTreeCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTreeCategory.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboTreeCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.cboTreeCategory.Size = new System.Drawing.Size(373, 26);
            this.cboTreeCategory.TabIndex = 9;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(280, -40);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // cboWarehouseItemCode
            // 
            this.cboWarehouseItemCode.Location = new System.Drawing.Point(669, 28);
            this.cboWarehouseItemCode.Name = "cboWarehouseItemCode";
            this.cboWarehouseItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouseItemCode.Properties.Appearance.Options.UseFont = true;
            this.cboWarehouseItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWarehouseItemCode.Size = new System.Drawing.Size(441, 24);
            this.cboWarehouseItemCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Warehouse ItemCode ::";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(119, 28);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Size = new System.Drawing.Size(373, 24);
            this.txtItemCode.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(37, 31);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(76, 17);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "ItemCode ::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Remark ::";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(119, 101);
            this.txtSize.Name = "txtSize";
            this.txtSize.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSize.Properties.Appearance.Options.UseFont = true;
            this.txtSize.Properties.Appearance.Options.UseForeColor = true;
            this.txtSize.Size = new System.Drawing.Size(137, 24);
            this.txtSize.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Size ::";
            // 
            // cboQtyUnit
            // 
            this.cboQtyUnit.Location = new System.Drawing.Point(349, 101);
            this.cboQtyUnit.Name = "cboQtyUnit";
            this.cboQtyUnit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQtyUnit.Properties.Appearance.Options.UseFont = true;
            this.cboQtyUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQtyUnit.Size = new System.Drawing.Size(143, 24);
            this.cboQtyUnit.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Qty Unit ::";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(669, 63);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(441, 62);
            this.txtRemark.TabIndex = 23;
            // 
            // ItemCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcItemCode);
            this.Controls.Add(this.panel1);
            this.Name = "ItemCode";
            this.Size = new System.Drawing.Size(1249, 741);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.ItemCode_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.ItemCode_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.ItemCode_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.ItemCode_ViewRefresh);
            ((System.ComponentModel.ISupportInitialize)(this.grcItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItemCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouseItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtyUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcItemCode;
        private DevExpress.XtraGrid.Views.Grid.GridView grvItemCode;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private DevExpress.XtraEditors.LookUpEdit cboWarehouseItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TreeListLookUpEdit cboTreeCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit cboQtyUnit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
    }
}
