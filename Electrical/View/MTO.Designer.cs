namespace Electrical.View
{
    partial class MTO
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
            this.grcMTO = new CMISControls.Grid.CMGridControl();
            this.grvMTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlFormFields = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblViewName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMTOQty = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cboItemCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMTO)).BeginInit();
            this.pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMTOQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcMTO
            // 
            this.grcMTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMTO.LoadingColor = System.Drawing.Color.Black;
            this.grcMTO.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcMTO.Location = new System.Drawing.Point(0, 168);
            this.grcMTO.MainView = this.grvMTO;
            this.grcMTO.Name = "grcMTO";
            this.grcMTO.Size = new System.Drawing.Size(1283, 605);
            this.grcMTO.TabIndex = 0;
            this.grcMTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMTO});
            this.grcMTO.DataSourceChanged += new System.EventHandler(this.grcMTO_DataSourceChanged);
            // 
            // grvMTO
            // 
            this.grvMTO.GridControl = this.grcMTO;
            this.grvMTO.Name = "grvMTO";
            this.grvMTO.OptionsBehavior.Editable = false;
            this.grvMTO.OptionsView.ShowAutoFilterRow = true;
            this.grvMTO.OptionsView.ShowFooter = true;
            this.grvMTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvMTO_FocusedRowChanged);
            // 
            // pnlFormFields
            // 
            this.pnlFormFields.Controls.Add(this.label2);
            this.pnlFormFields.Controls.Add(this.txtDescription);
            this.pnlFormFields.Controls.Add(this.label1);
            this.pnlFormFields.Controls.Add(this.cboUnit);
            this.pnlFormFields.Controls.Add(this.separatorControl1);
            this.pnlFormFields.Controls.Add(this.lblViewName);
            this.pnlFormFields.Controls.Add(this.label10);
            this.pnlFormFields.Controls.Add(this.txtMTOQty);
            this.pnlFormFields.Controls.Add(this.label8);
            this.pnlFormFields.Controls.Add(this.cboItemCode);
            this.pnlFormFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFormFields.Name = "pnlFormFields";
            this.pnlFormFields.Size = new System.Drawing.Size(1283, 168);
            this.pnlFormFields.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(704, 46);
            this.txtDescription.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Unit";
            // 
            // cboUnit
            // 
            this.cboUnit.Location = new System.Drawing.Point(107, 65);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboUnit.Properties.Appearance.Options.UseFont = true;
            this.cboUnit.Properties.Appearance.Options.UseForeColor = true;
            this.cboUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUnit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboUnit.Size = new System.Drawing.Size(161, 24);
            this.cboUnit.TabIndex = 26;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 39);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(862, 23);
            this.separatorControl1.TabIndex = 25;
            // 
            // lblViewName
            // 
            this.lblViewName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewName.Location = new System.Drawing.Point(34, 13);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(171, 28);
            this.lblViewName.TabIndex = 24;
            this.lblViewName.Text = "MTO";
            this.lblViewName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(283, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "ItemCode";
            // 
            // txtMTOQty
            // 
            this.txtMTOQty.EditValue = "0.00";
            this.txtMTOQty.Location = new System.Drawing.Point(718, 65);
            this.txtMTOQty.Name = "txtMTOQty";
            this.txtMTOQty.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTOQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtMTOQty.Properties.Appearance.Options.UseFont = true;
            this.txtMTOQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtMTOQty.Properties.Mask.EditMask = "n2";
            this.txtMTOQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMTOQty.Properties.Mask.ShowPlaceHolders = false;
            this.txtMTOQty.Size = new System.Drawing.Size(93, 24);
            this.txtMTOQty.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(636, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "MTO QTY";
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(355, 65);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboItemCode.Properties.Appearance.Options.UseFont = true;
            this.cboItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.cboItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItemCode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboItemCode.Size = new System.Drawing.Size(266, 24);
            this.cboItemCode.TabIndex = 19;
            // 
            // MTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcMTO);
            this.Controls.Add(this.pnlFormFields);
            this.Name = "MTO";
            this.Size = new System.Drawing.Size(1283, 773);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.MTO_RibbonPageAdded);
            this.BeforeViewLoad += new System.EventHandler(this.MTO_BeforeViewLoad);
            this.ViewLoaded += new System.EventHandler(this.MTO_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.MTO_ViewRefresh);
            ((System.ComponentModel.ISupportInitialize)(this.grcMTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMTO)).EndInit();
            this.pnlFormFields.ResumeLayout(false);
            this.pnlFormFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMTOQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcMTO;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMTO;
        private System.Windows.Forms.Panel pnlFormFields;
        private DevExpress.XtraEditors.TextEdit txtMTOQty;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LookUpEdit cboItemCode;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cboUnit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}
