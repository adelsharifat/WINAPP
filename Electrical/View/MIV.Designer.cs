namespace Electrical.View
{
    partial class MIV
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
            this.grcMIVItems = new CMISControls.Grid.CMGridControl();
            this.grvMIVItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCompanies = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReport = new DevExpress.XtraEditors.TextEdit();
            this.lblreportNo = new System.Windows.Forms.Label();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.cboItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDocuemntRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lblItemRemark = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemRemark = new DevExpress.XtraEditors.MemoEdit();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMIVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMIVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuemntRemark.Properties)).BeginInit();
            this.pnlFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderBottomSeperator
            // 
            this.pnlHeaderBottomSeperator.Size = new System.Drawing.Size(1297, 1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1297, 52);
            // 
            // cmbCompany
            // 
            this.cmbCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.Properties.Appearance.Options.UseFont = true;
            // 
            // label1
            // 
            this.label1.Text = "Contractor";
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1297, 51);
            // 
            // grcMIVItems
            // 
            this.grcMIVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMIVItems.LoadingColor = System.Drawing.Color.Black;
            this.grcMIVItems.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcMIVItems.Location = new System.Drawing.Point(0, 256);
            this.grcMIVItems.MainView = this.grvMIVItems;
            this.grcMIVItems.Name = "grcMIVItems";
            this.grcMIVItems.Size = new System.Drawing.Size(1297, 553);
            this.grcMIVItems.TabIndex = 2;
            this.grcMIVItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMIVItems});
            // 
            // grvMIVItems
            // 
            this.grvMIVItems.GridControl = this.grcMIVItems;
            this.grvMIVItems.Name = "grvMIVItems";
            this.grvMIVItems.OptionsView.ShowAutoFilterRow = true;
            this.grvMIVItems.OptionsView.ShowFooter = true;
            this.grvMIVItems.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvMIVItems_CellValueChanged);
            this.grvMIVItems.DoubleClick += new System.EventHandler(this.grvMIVItems_DoubleClick);
            this.grvMIVItems.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.grvMIVItems_ValidatingEditor);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Company";
            // 
            // cboCompanies
            // 
            this.cboCompanies.Location = new System.Drawing.Point(110, 95);
            this.cboCompanies.Name = "cboCompanies";
            this.cboCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboCompanies.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompanies.Properties.Appearance.Options.UseFont = true;
            this.cboCompanies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCompanies.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboCompanies.Size = new System.Drawing.Size(281, 24);
            this.cboCompanies.TabIndex = 24;
            this.cboCompanies.EditValueChanged += new System.EventHandler(this.cboVendor_EditValueChanged);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(110, 61);
            this.txtReport.Name = "txtReport";
            this.txtReport.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtReport.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtReport.Properties.Appearance.Options.UseBackColor = true;
            this.txtReport.Properties.Appearance.Options.UseFont = true;
            this.txtReport.Properties.Appearance.Options.UseForeColor = true;
            this.txtReport.Size = new System.Drawing.Size(281, 24);
            this.txtReport.TabIndex = 22;
            this.txtReport.EditValueChanged += new System.EventHandler(this.txtReport_EditValueChanged);
            // 
            // lblreportNo
            // 
            this.lblreportNo.AutoSize = true;
            this.lblreportNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreportNo.ForeColor = System.Drawing.Color.Black;
            this.lblreportNo.Location = new System.Drawing.Point(41, 64);
            this.lblreportNo.Name = "lblreportNo";
            this.lblreportNo.Size = new System.Drawing.Size(63, 17);
            this.lblreportNo.TabIndex = 23;
            this.lblreportNo.Text = "MIV No.";
            // 
            // txtQty
            // 
            this.txtQty.EditValue = "0.00";
            this.txtQty.Location = new System.Drawing.Point(533, 147);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Properties.Appearance.Options.UseBackColor = true;
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtQty.Properties.Mask.EditMask = "n2";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Properties.Mask.ShowPlaceHolders = false;
            this.txtQty.Size = new System.Drawing.Size(153, 26);
            this.txtQty.TabIndex = 31;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.ImageOptions.Image = global::Electrical.ElectricalResource.Plus;
            this.btnAddItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddItem.ImageOptions.ImageToTextIndent = 8;
            this.btnAddItem.Location = new System.Drawing.Point(692, 146);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(145, 26);
            this.btnAddItem.TabIndex = 30;
            this.btnAddItem.Text = "AddItem";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(533, 61);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboItemCode.Properties.Appearance.Options.UseFont = true;
            this.cboItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.cboItemCode.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItemCode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboItemCode.Size = new System.Drawing.Size(304, 24);
            this.cboItemCode.TabIndex = 29;
            // 
            // txtDocuemntRemark
            // 
            this.txtDocuemntRemark.Location = new System.Drawing.Point(110, 129);
            this.txtDocuemntRemark.Name = "txtDocuemntRemark";
            this.txtDocuemntRemark.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocuemntRemark.Size = new System.Drawing.Size(281, 44);
            this.txtDocuemntRemark.TabIndex = 28;
            // 
            // lblItemRemark
            // 
            this.lblItemRemark.AutoSize = true;
            this.lblItemRemark.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRemark.ForeColor = System.Drawing.Color.Black;
            this.lblItemRemark.Location = new System.Drawing.Point(41, 129);
            this.lblItemRemark.Name = "lblItemRemark";
            this.lblItemRemark.Size = new System.Drawing.Size(55, 17);
            this.lblItemRemark.TabIndex = 27;
            this.lblItemRemark.Text = "Remark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(461, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "ItemCode";
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.label6);
            this.pnlFields.Controls.Add(this.txtItemRemark);
            this.pnlFields.Controls.Add(this.separatorControl2);
            this.pnlFields.Controls.Add(this.separatorControl1);
            this.pnlFields.Controls.Add(this.label4);
            this.pnlFields.Controls.Add(this.label3);
            this.pnlFields.Controls.Add(this.txtQty);
            this.pnlFields.Controls.Add(this.btnAddItem);
            this.pnlFields.Controls.Add(this.label2);
            this.pnlFields.Controls.Add(this.label7);
            this.pnlFields.Controls.Add(this.lblreportNo);
            this.pnlFields.Controls.Add(this.cboCompanies);
            this.pnlFields.Controls.Add(this.lblItemRemark);
            this.pnlFields.Controls.Add(this.txtDocuemntRemark);
            this.pnlFields.Controls.Add(this.cboItemCode);
            this.pnlFields.Controls.Add(this.txtReport);
            this.pnlFields.Controls.Add(this.label5);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFields.Location = new System.Drawing.Point(0, 52);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(1297, 204);
            this.pnlFields.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(461, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Remark";
            // 
            // txtItemRemark
            // 
            this.txtItemRemark.Location = new System.Drawing.Point(533, 94);
            this.txtItemRemark.Name = "txtItemRemark";
            this.txtItemRemark.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtItemRemark.Properties.Appearance.Options.UseForeColor = true;
            this.txtItemRemark.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemRemark.Size = new System.Drawing.Size(304, 44);
            this.txtItemRemark.TabIndex = 36;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(433, 36);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(429, 23);
            this.separatorControl2.TabIndex = 35;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(21, 36);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(391, 23);
            this.separatorControl1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(461, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "ITEM CODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "MIV HEADER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(461, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "QTY";
            // 
            // MIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcMIVItems);
            this.Controls.Add(this.pnlFields);
            this.Name = "MIV";
            this.Size = new System.Drawing.Size(1297, 809);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.MIV_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.MIV_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.MIV_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.MIV_ViewRefresh);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.pnlFields, 0);
            this.Controls.SetChildIndex(this.grcMIVItems, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMIVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMIVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCompanies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuemntRemark.Properties)).EndInit();
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcMIVItems;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMIVItems;
        private DevExpress.XtraEditors.TextEdit txtReport;
        private System.Windows.Forms.Label lblreportNo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit cboCompanies;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.LookUpEdit cboItemCode;
        private DevExpress.XtraEditors.MemoEdit txtDocuemntRemark;
        private System.Windows.Forms.Label lblItemRemark;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private System.Windows.Forms.Panel pnlFields;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit txtItemRemark;
    }
}
