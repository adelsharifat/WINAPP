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
            this.cboWarehouseItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.lblItemCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItemCode)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouseItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcItemCode
            // 
            this.grcItemCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcItemCode.LoadingColor = System.Drawing.Color.Black;
            this.grcItemCode.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcItemCode.Location = new System.Drawing.Point(0, 121);
            this.grcItemCode.MainView = this.grvItemCode;
            this.grcItemCode.Name = "grcItemCode";
            this.grcItemCode.Size = new System.Drawing.Size(1249, 620);
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
            this.panel1.Controls.Add(this.cboWarehouseItemCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.lblItemCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 121);
            this.panel1.TabIndex = 1;
            // 
            // cboWarehouseItemCode
            // 
            this.cboWarehouseItemCode.Location = new System.Drawing.Point(683, 28);
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
            this.label2.Location = new System.Drawing.Point(531, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Warehouse ItemCode ::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category ::";
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(121, 69);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.Properties.Appearance.Options.UseFont = true;
            this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategory.Size = new System.Drawing.Size(300, 24);
            this.cboCategory.TabIndex = 2;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(119, 28);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Size = new System.Drawing.Size(382, 24);
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
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouseItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cboCategory;
    }
}
