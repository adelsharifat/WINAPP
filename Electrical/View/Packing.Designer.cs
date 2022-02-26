namespace Electrical.View
{
    partial class Packing
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
            this.grpPL = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTreeCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.cboUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblTag = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cboQtyUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.cboItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlQty = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.cboVendor = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.txtPackingNo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPLHeader = new DevExpress.XtraEditors.GroupControl();
            this.txtReport = new DevExpress.XtraEditors.TextEdit();
            this.lblreportNo = new System.Windows.Forms.Label();
            this.grcPacking = new CMISControls.Grid.CMGridControl();
            this.grvPaking = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsGrcPacking = new System.Windows.Forms.ToolStrip();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditItem = new System.Windows.Forms.ToolStripButton();
            this.spliteContainer = new System.Windows.Forms.SplitContainer();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPL)).BeginInit();
            this.grpPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtyUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPLHeader)).BeginInit();
            this.grpPLHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPaking)).BeginInit();
            this.tsGrcPacking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spliteContainer)).BeginInit();
            this.spliteContainer.Panel1.SuspendLayout();
            this.spliteContainer.Panel2.SuspendLayout();
            this.spliteContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1425, 1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1425, 52);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            this.cmbCompany.EditValueChanged += new System.EventHandler(this.cmbCompany_EditValueChanged);
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1425, 51);
            // 
            // grpPL
            // 
            this.grpPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPL.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPL.AppearanceCaption.Options.UseFont = true;
            this.grpPL.Controls.Add(this.label2);
            this.grpPL.Controls.Add(this.label3);
            this.grpPL.Controls.Add(this.cboTreeCategory);
            this.grpPL.Controls.Add(this.btnCancel);
            this.grpPL.Controls.Add(this.btnAddItem);
            this.grpPL.Controls.Add(this.cboUnit);
            this.grpPL.Controls.Add(this.lblUnit);
            this.grpPL.Controls.Add(this.txtDescription);
            this.grpPL.Controls.Add(this.lblTag);
            this.grpPL.Controls.Add(this.label10);
            this.grpPL.Controls.Add(this.txtTag);
            this.grpPL.Controls.Add(this.label6);
            this.grpPL.Controls.Add(this.cboQtyUnit);
            this.grpPL.Controls.Add(this.cboItemCode);
            this.grpPL.Controls.Add(this.label9);
            this.grpPL.Controls.Add(this.label8);
            this.grpPL.Controls.Add(this.txtPlQty);
            this.grpPL.Controls.Add(this.label7);
            this.grpPL.Controls.Add(this.cboVendor);
            this.grpPL.Controls.Add(this.label4);
            this.grpPL.Controls.Add(this.txtSize);
            this.grpPL.Controls.Add(this.txtPackingNo);
            this.grpPL.Controls.Add(this.label5);
            this.grpPL.Location = new System.Drawing.Point(12, 88);
            this.grpPL.Name = "grpPL";
            this.grpPL.Size = new System.Drawing.Size(428, 627);
            this.grpPL.TabIndex = 25;
            this.grpPL.Text = "P/L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Category";
            // 
            // cboTreeCategory
            // 
            this.cboTreeCategory.Location = new System.Drawing.Point(97, 80);
            this.cboTreeCategory.Name = "cboTreeCategory";
            this.cboTreeCategory.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTreeCategory.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboTreeCategory.Properties.Appearance.Options.UseFont = true;
            this.cboTreeCategory.Properties.Appearance.Options.UseForeColor = true;
            this.cboTreeCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTreeCategory.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboTreeCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.cboTreeCategory.Size = new System.Drawing.Size(316, 26);
            this.cboTreeCategory.TabIndex = 1;
            this.cboTreeCategory.EditValueChanged += new System.EventHandler(this.cboCategory_EditValueChanged);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(-130, 213);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::Electrical.ElectricalResource.Invalid;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.ImageOptions.ImageToTextIndent = 8;
            this.btnCancel.Location = new System.Drawing.Point(246, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 50);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.ImageOptions.Image = global::Electrical.ElectricalResource.Plus;
            this.btnAddItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddItem.ImageOptions.ImageToTextIndent = 8;
            this.btnAddItem.Location = new System.Drawing.Point(97, 452);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(143, 50);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Add/Update Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cboUnit
            // 
            this.cboUnit.Location = new System.Drawing.Point(97, 44);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboUnit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboUnit.Properties.Appearance.Options.UseFont = true;
            this.cboUnit.Properties.Appearance.Options.UseForeColor = true;
            this.cboUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUnit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboUnit.Size = new System.Drawing.Size(131, 24);
            this.cboUnit.TabIndex = 0;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Black;
            this.lblUnit.Location = new System.Drawing.Point(11, 47);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 17);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Unit";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 350);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(316, 96);
            this.txtDescription.TabIndex = 9;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.Color.Black;
            this.lblTag.Location = new System.Drawing.Point(11, 158);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(71, 17);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "TAG NO. ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "ItemCode";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(97, 155);
            this.txtTag.Name = "txtTag";
            this.txtTag.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTag.Properties.Appearance.Options.UseFont = true;
            this.txtTag.Properties.Appearance.Options.UseForeColor = true;
            this.txtTag.Size = new System.Drawing.Size(316, 24);
            this.txtTag.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descriptions";
            // 
            // cboQtyUnit
            // 
            this.cboQtyUnit.Location = new System.Drawing.Point(97, 307);
            this.cboQtyUnit.Name = "cboQtyUnit";
            this.cboQtyUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboQtyUnit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQtyUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboQtyUnit.Properties.Appearance.Options.UseFont = true;
            this.cboQtyUnit.Properties.Appearance.Options.UseForeColor = true;
            this.cboQtyUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQtyUnit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboQtyUnit.Size = new System.Drawing.Size(316, 24);
            this.cboQtyUnit.TabIndex = 8;
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(97, 119);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboItemCode.Properties.Appearance.Options.UseFont = true;
            this.cboItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.cboItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItemCode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboItemCode.Size = new System.Drawing.Size(316, 24);
            this.cboItemCode.TabIndex = 2;
            this.cboItemCode.EditValueChanged += new System.EventHandler(this.cboItemCode_EditValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "QTY Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(231, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "P/L QTY";
            // 
            // txtPlQty
            // 
            this.txtPlQty.Location = new System.Drawing.Point(300, 269);
            this.txtPlQty.Name = "txtPlQty";
            this.txtPlQty.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPlQty.Properties.Appearance.Options.UseFont = true;
            this.txtPlQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtPlQty.Properties.Mask.EditMask = "n2";
            this.txtPlQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPlQty.Properties.Mask.ShowPlaceHolders = false;
            this.txtPlQty.Size = new System.Drawing.Size(113, 24);
            this.txtPlQty.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vendor";
            // 
            // cboVendor
            // 
            this.cboVendor.Location = new System.Drawing.Point(97, 230);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboVendor.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendor.Properties.Appearance.Options.UseFont = true;
            this.cboVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVendor.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboVendor.Size = new System.Drawing.Size(316, 24);
            this.cboVendor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(97, 269);
            this.txtSize.Name = "txtSize";
            this.txtSize.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSize.Properties.Appearance.Options.UseFont = true;
            this.txtSize.Properties.Appearance.Options.UseForeColor = true;
            this.txtSize.Size = new System.Drawing.Size(108, 24);
            this.txtSize.TabIndex = 6;
            // 
            // txtPackingNo
            // 
            this.txtPackingNo.Location = new System.Drawing.Point(97, 192);
            this.txtPackingNo.Name = "txtPackingNo";
            this.txtPackingNo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackingNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPackingNo.Properties.Appearance.Options.UseFont = true;
            this.txtPackingNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtPackingNo.Size = new System.Drawing.Size(316, 24);
            this.txtPackingNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Packing No.";
            // 
            // grpPLHeader
            // 
            this.grpPLHeader.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPLHeader.AppearanceCaption.Options.UseFont = true;
            this.grpPLHeader.Controls.Add(this.txtReport);
            this.grpPLHeader.Controls.Add(this.lblreportNo);
            this.grpPLHeader.Location = new System.Drawing.Point(12, 10);
            this.grpPLHeader.Name = "grpPLHeader";
            this.grpPLHeader.Size = new System.Drawing.Size(428, 72);
            this.grpPLHeader.TabIndex = 24;
            this.grpPLHeader.Text = "Document Header";
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(101, 34);
            this.txtReport.Name = "txtReport";
            this.txtReport.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtReport.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtReport.Properties.Appearance.Options.UseBackColor = true;
            this.txtReport.Properties.Appearance.Options.UseFont = true;
            this.txtReport.Properties.Appearance.Options.UseForeColor = true;
            this.txtReport.Properties.ReadOnly = true;
            this.txtReport.Size = new System.Drawing.Size(316, 24);
            this.txtReport.TabIndex = 22;
            // 
            // lblreportNo
            // 
            this.lblreportNo.AutoSize = true;
            this.lblreportNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreportNo.ForeColor = System.Drawing.Color.Black;
            this.lblreportNo.Location = new System.Drawing.Point(11, 35);
            this.lblreportNo.Name = "lblreportNo";
            this.lblreportNo.Size = new System.Drawing.Size(74, 17);
            this.lblreportNo.TabIndex = 23;
            this.lblreportNo.Text = "Report No.";
            // 
            // grcPacking
            // 
            this.grcPacking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPacking.LoadingColor = System.Drawing.Color.Black;
            this.grcPacking.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcPacking.Location = new System.Drawing.Point(0, 25);
            this.grcPacking.MainView = this.grvPaking;
            this.grcPacking.Name = "grcPacking";
            this.grcPacking.Size = new System.Drawing.Size(968, 766);
            this.grcPacking.TabIndex = 2;
            this.grcPacking.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPaking});
            this.grcPacking.DataSourceChanged += new System.EventHandler(this.grcPacking_DataSourceChanged);
            // 
            // grvPaking
            // 
            this.grvPaking.GridControl = this.grcPacking;
            this.grvPaking.Name = "grvPaking";
            this.grvPaking.OptionsBehavior.Editable = false;
            this.grvPaking.OptionsView.ShowAutoFilterRow = true;
            this.grvPaking.OptionsView.ShowFooter = true;
            this.grvPaking.DoubleClick += new System.EventHandler(this.btnEditItem_Click);
            // 
            // tsGrcPacking
            // 
            this.tsGrcPacking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteItem,
            this.btnEditItem});
            this.tsGrcPacking.Location = new System.Drawing.Point(0, 0);
            this.tsGrcPacking.Name = "tsGrcPacking";
            this.tsGrcPacking.Size = new System.Drawing.Size(968, 25);
            this.tsGrcPacking.TabIndex = 3;
            this.tsGrcPacking.Text = "toolStrip1";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Image = global::Electrical.ElectricalResource.trash_32x32;
            this.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Image = global::Electrical.ElectricalResource.edit_32x32;
            this.btnEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(47, 22);
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // spliteContainer
            // 
            this.spliteContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spliteContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spliteContainer.IsSplitterFixed = true;
            this.spliteContainer.Location = new System.Drawing.Point(0, 52);
            this.spliteContainer.Name = "spliteContainer";
            // 
            // spliteContainer.Panel1
            // 
            this.spliteContainer.Panel1.Controls.Add(this.grpPL);
            this.spliteContainer.Panel1.Controls.Add(this.grpPLHeader);
            // 
            // spliteContainer.Panel2
            // 
            this.spliteContainer.Panel2.Controls.Add(this.grcPacking);
            this.spliteContainer.Panel2.Controls.Add(this.tsGrcPacking);
            this.spliteContainer.Size = new System.Drawing.Size(1425, 791);
            this.spliteContainer.SplitterDistance = 453;
            this.spliteContainer.TabIndex = 4;
            // 
            // Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spliteContainer);
            this.Name = "Packing";
            this.Size = new System.Drawing.Size(1425, 843);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.Packing_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.Packing_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.Packing_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.Packing_ViewRefresh);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.spliteContainer, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPL)).EndInit();
            this.grpPL.ResumeLayout(false);
            this.grpPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTreeCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtyUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPLHeader)).EndInit();
            this.grpPLHeader.ResumeLayout(false);
            this.grpPLHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPaking)).EndInit();
            this.tsGrcPacking.ResumeLayout(false);
            this.tsGrcPacking.PerformLayout();
            this.spliteContainer.Panel1.ResumeLayout(false);
            this.spliteContainer.Panel2.ResumeLayout(false);
            this.spliteContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spliteContainer)).EndInit();
            this.spliteContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CMISControls.Grid.CMGridControl grcPacking;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPaking;
        private System.Windows.Forms.Label lblUnit;
        private DevExpress.XtraEditors.LookUpEdit cboUnit;
        private System.Windows.Forms.Label lblTag;
        private DevExpress.XtraEditors.TextEdit txtTag;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtPackingNo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LookUpEdit cboQtyUnit;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtPlQty;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit cboVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.LookUpEdit cboItemCode;
        private DevExpress.XtraEditors.GroupControl grpPL;
        private DevExpress.XtraEditors.GroupControl grpPLHeader;
        private DevExpress.XtraEditors.TextEdit txtReport;
        private System.Windows.Forms.Label lblreportNo;
        private System.Windows.Forms.ToolStrip tsGrcPacking;
        private System.Windows.Forms.ToolStripButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private System.Windows.Forms.SplitContainer spliteContainer;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.ToolStripButton btnEditItem;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TreeListLookUpEdit cboTreeCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private System.Windows.Forms.Label label2;
    }
}
