namespace QCElectrical.View.BaseInfo
{
    partial class frmCFItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCFItem));
            this.grcCFItem = new CMISControls.Grid.CMGridControl();
            this.grvCFItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCFItemToList = new DevExpress.XtraEditors.SimpleButton();
            this.lblSelectedCF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCF = new CMISControls.Combo.CMLookupEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteCFItemToolStrip = new System.Windows.Forms.ToolStripButton();
            this.btnAddCFItemToolStrip = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcCFItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCFItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcCFItem
            // 
            this.grcCFItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCFItem.LoadingColor = System.Drawing.Color.Black;
            this.grcCFItem.LoadingStyle = CMISControls.Grid.LoadingStyle.Dashed;
            this.grcCFItem.Location = new System.Drawing.Point(0, 222);
            this.grcCFItem.MainView = this.grvCFItem;
            this.grcCFItem.Name = "grcCFItem";
            this.grcCFItem.Size = new System.Drawing.Size(1090, 520);
            this.grcCFItem.TabIndex = 0;
            this.grcCFItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCFItem});
            // 
            // grvCFItem
            // 
            this.behaviorManager.SetBehaviors(this.grvCFItem, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents1)))});
            this.grvCFItem.GridControl = this.grcCFItem;
            this.grvCFItem.Name = "grvCFItem";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 100);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Size = new System.Drawing.Size(586, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.btnAddCFItemToList);
            this.pnlTop.Controls.Add(this.lblSelectedCF);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cmbCF);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1090, 197);
            this.pnlTop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note ::  You can reorder row by drag and drop or set custom order value to \"Order" +
    "\" cell";
            // 
            // btnAddCFItemToList
            // 
            this.btnAddCFItemToList.ImageOptions.Image = global::QCElectrical.Properties.Resources.Plus;
            this.btnAddCFItemToList.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCFItemToList.ImageOptions.ImageToTextIndent = 8;
            this.btnAddCFItemToList.Location = new System.Drawing.Point(70, 128);
            this.btnAddCFItemToList.Name = "btnAddCFItemToList";
            this.btnAddCFItemToList.Size = new System.Drawing.Size(109, 37);
            this.btnAddCFItemToList.TabIndex = 7;
            this.btnAddCFItemToList.Text = "Add To List";
            this.btnAddCFItemToList.Click += new System.EventHandler(this.btnAddCFItemToList_Click);
            // 
            // lblSelectedCF
            // 
            this.lblSelectedCF.AutoSize = true;
            this.lblSelectedCF.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCF.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedCF.Location = new System.Drawing.Point(140, 33);
            this.lblSelectedCF.Name = "lblSelectedCF";
            this.lblSelectedCF.Size = new System.Drawing.Size(17, 24);
            this.lblSelectedCF.TabIndex = 6;
            this.lblSelectedCF.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(66, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "CF ::";
            // 
            // cmbCF
            // 
            this.cmbCF.Location = new System.Drawing.Point(730, 100);
            this.cmbCF.Name = "cmbCF";
            this.cmbCF.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCF.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbCF.Properties.Appearance.Options.UseFont = true;
            this.cmbCF.Properties.Appearance.Options.UseForeColor = true;
            this.cmbCF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCF.Properties.NullText = "-";
            this.cmbCF.Size = new System.Drawing.Size(301, 22);
            this.cmbCF.TabIndex = 4;
            this.cmbCF.EditValueChanged += new System.EventHandler(this.cmbCF_EditValueChanged);
            this.cmbCF.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmbCF_EditValueChanging);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CF ::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name ::";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCFItemToolStrip,
            this.btnAddCFItemToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 197);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1090, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDeleteCFItemToolStrip
            // 
            this.btnDeleteCFItemToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCFItemToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCFItemToolStrip.Image")));
            this.btnDeleteCFItemToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCFItemToolStrip.Name = "btnDeleteCFItemToolStrip";
            this.btnDeleteCFItemToolStrip.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCFItemToolStrip.Click += new System.EventHandler(this.btnDeleteCFItemToolStrip_Click);
            // 
            // btnAddCFItemToolStrip
            // 
            this.btnAddCFItemToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCFItemToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCFItemToolStrip.Image")));
            this.btnAddCFItemToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCFItemToolStrip.Name = "btnAddCFItemToolStrip";
            this.btnAddCFItemToolStrip.Size = new System.Drawing.Size(23, 22);
            // 
            // frmCFItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcCFItem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmCFItem";
            this.Size = new System.Drawing.Size(1090, 742);
            this.RibbonPageAdded += new CMISUIHelper.UserControls.ViewTab.RibbonPageEventHandler(this.frmCFItem_RibbonPageAdded);
            this.ViewLoaded += new System.EventHandler(this.frmCFItem_ViewLoaded);
            this.ViewRefresh += new System.EventHandler(this.frmCFItem_ViewRefresh);
            ((System.ComponentModel.ISupportInitialize)(this.grcCFItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCFItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMISControls.Grid.CMGridControl grcCFItem;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCFItem;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSelectedCF;
        private System.Windows.Forms.Label label3;
        private CMISControls.Combo.CMLookupEdit cmbCF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDeleteCFItemToolStrip;
        private System.Windows.Forms.ToolStripButton btnAddCFItemToolStrip;
        private DevExpress.XtraEditors.SimpleButton btnAddCFItemToList;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private System.Windows.Forms.Label label4;
    }
}
