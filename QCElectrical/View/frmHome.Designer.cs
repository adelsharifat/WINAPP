namespace QCElectrical.View
{
    partial class frmHome
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileMain = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileCFItem = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileNewCF = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileCFList = new DevExpress.XtraEditors.TileItem();
            this.tileGroup5 = new DevExpress.XtraEditors.TileGroup();
            this.tileCFReport = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileMain
            // 
            this.tileMain.AppearanceGroupText.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileMain.AppearanceGroupText.Options.UseFont = true;
            this.tileMain.AppearanceText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileMain.AppearanceText.Options.UseFont = true;
            this.tileMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileMain.Groups.Add(this.tileGroup2);
            this.tileMain.Groups.Add(this.tileGroup3);
            this.tileMain.Groups.Add(this.tileGroup4);
            this.tileMain.Groups.Add(this.tileGroup5);
            this.tileMain.Location = new System.Drawing.Point(20, 20);
            this.tileMain.MaxId = 4;
            this.tileMain.Name = "tileMain";
            this.tileMain.ShowGroupText = true;
            this.tileMain.ShowText = true;
            this.tileMain.Size = new System.Drawing.Size(1160, 712);
            this.tileMain.TabIndex = 0;
            this.tileMain.Text = "QC ELECTRICAL";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileCFItem);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Base Info";
            // 
            // tileCFItem
            // 
            this.tileCFItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Orange;
            this.tileCFItem.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileCFItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileCFItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCFItem.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileCFItem.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "CF ITEM";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileCFItem.Elements.Add(tileItemElement1);
            this.tileCFItem.Id = 0;
            this.tileCFItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileCFItem.Name = "tileCFItem";
            this.tileCFItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCFItem_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileNewCF);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "CF";
            // 
            // tileNewCF
            // 
            this.tileNewCF.AppearanceItem.Normal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tileNewCF.AppearanceItem.Normal.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.tileNewCF.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNewCF.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNewCF.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileNewCF.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "NEW CF";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileNewCF.Elements.Add(tileItemElement2);
            this.tileNewCF.Id = 1;
            this.tileNewCF.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileNewCF.Name = "tileNewCF";
            this.tileNewCF.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileNewCF_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileCFList);
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = "CF List";
            // 
            // tileCFList
            // 
            this.tileCFList.AppearanceItem.Normal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tileCFList.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tileCFList.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileCFList.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCFList.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileCFList.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "CF LIST";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileCFList.Elements.Add(tileItemElement3);
            this.tileCFList.Id = 2;
            this.tileCFList.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileCFList.Name = "tileCFList";
            this.tileCFList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCFList_ItemClick);
            // 
            // tileGroup5
            // 
            this.tileGroup5.Items.Add(this.tileCFReport);
            this.tileGroup5.Name = "tileGroup5";
            this.tileGroup5.Text = "Report";
            // 
            // tileCFReport
            // 
            this.tileCFReport.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tileCFReport.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(255)))));
            this.tileCFReport.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileCFReport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCFReport.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileCFReport.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "CF";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileCFReport.Elements.Add(tileItemElement4);
            this.tileCFReport.Id = 3;
            this.tileCFReport.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileCFReport.Name = "tileCFReport";
            this.tileCFReport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCFReport_ItemClick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileMain);
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1200, 752);
            this.ViewLoaded += new System.EventHandler(this.frmHome_ViewLoaded);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileMain;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileCFItem;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileNewCF;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileCFList;
        private DevExpress.XtraEditors.TileGroup tileGroup5;
        private DevExpress.XtraEditors.TileItem tileCFReport;
    }
}
