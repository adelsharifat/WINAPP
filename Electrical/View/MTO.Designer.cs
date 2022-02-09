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
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlQty = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.cboItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcMTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMTO)).BeginInit();
            this.pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // grcMTO
            // 
            this.grcMTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMTO.LoadingColor = System.Drawing.Color.Black;
            this.grcMTO.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcMTO.Location = new System.Drawing.Point(0, 128);
            this.grcMTO.MainView = this.grvMTO;
            this.grcMTO.Name = "grcMTO";
            this.grcMTO.Size = new System.Drawing.Size(1283, 645);
            this.grcMTO.TabIndex = 0;
            this.grcMTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMTO});
            // 
            // grvMTO
            // 
            this.grvMTO.GridControl = this.grcMTO;
            this.grvMTO.Name = "grvMTO";
            // 
            // pnlFormFields
            // 
            this.pnlFormFields.Controls.Add(this.separatorControl1);
            this.pnlFormFields.Controls.Add(this.lblViewName);
            this.pnlFormFields.Controls.Add(this.lblUnit);
            this.pnlFormFields.Controls.Add(this.label10);
            this.pnlFormFields.Controls.Add(this.txtPlQty);
            this.pnlFormFields.Controls.Add(this.label8);
            this.pnlFormFields.Controls.Add(this.cboUnit);
            this.pnlFormFields.Controls.Add(this.cboItemCode);
            this.pnlFormFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFormFields.Name = "pnlFormFields";
            this.pnlFormFields.Size = new System.Drawing.Size(1283, 128);
            this.pnlFormFields.TabIndex = 1;
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
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Black;
            this.lblUnit.Location = new System.Drawing.Point(35, 71);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 17);
            this.lblUnit.TabIndex = 22;
            this.lblUnit.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(242, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "ItemCode";
            // 
            // txtPlQty
            // 
            this.txtPlQty.Location = new System.Drawing.Point(735, 68);
            this.txtPlQty.Name = "txtPlQty";
            this.txtPlQty.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPlQty.Properties.Appearance.Options.UseFont = true;
            this.txtPlQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtPlQty.Properties.Mask.EditMask = "n2";
            this.txtPlQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPlQty.Properties.Mask.ShowPlaceHolders = false;
            this.txtPlQty.Size = new System.Drawing.Size(113, 24);
            this.txtPlQty.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(665, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "P/L QTY";
            // 
            // cboUnit
            // 
            this.cboUnit.Location = new System.Drawing.Point(74, 68);
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
            this.cboUnit.TabIndex = 18;
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(314, 68);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cboItemCode.Properties.Appearance.Options.UseFont = true;
            this.cboItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.cboItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItemCode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboItemCode.Size = new System.Drawing.Size(316, 24);
            this.cboItemCode.TabIndex = 19;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 39);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(862, 23);
            this.separatorControl1.TabIndex = 25;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtPlQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcMTO;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMTO;
        private System.Windows.Forms.Panel pnlFormFields;
        private DevExpress.XtraEditors.TextEdit txtPlQty;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LookUpEdit cboUnit;
        private DevExpress.XtraEditors.LookUpEdit cboItemCode;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}
