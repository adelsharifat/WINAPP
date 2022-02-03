namespace Electrical.View
{
    partial class Home
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tgBaseInfo = new DevExpress.XtraEditors.TileGroup();
            this.tileItemCode = new DevExpress.XtraEditors.TileItem();
            this.tileCategory = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileNewPL = new DevExpress.XtraEditors.TileItem();
            this.tilePakingList = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AppearanceText.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl1.AppearanceText.Options.UseFont = true;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tgBaseInfo);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(50, 50);
            this.tileControl1.MaxId = 5;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.ShowText = true;
            this.tileControl1.Size = new System.Drawing.Size(1172, 670);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "Electrical";
            // 
            // tgBaseInfo
            // 
            this.tgBaseInfo.Items.Add(this.tileItemCode);
            this.tgBaseInfo.Items.Add(this.tileCategory);
            this.tgBaseInfo.Name = "tgBaseInfo";
            this.tgBaseInfo.Text = "Base Info";
            // 
            // tileItemCode
            // 
            this.tileItemCode.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileItemCode.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Teal;
            this.tileItemCode.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemCode.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemCode.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemCode.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemCode.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItemCode.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileItemCode.AppearanceItem.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.Text = "Item Code";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemCode.Elements.Add(tileItemElement1);
            this.tileItemCode.Id = 1;
            this.tileItemCode.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemCode.Name = "tileItemCode";
            this.tileItemCode.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.tileItemCode.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItemCode_ItemClick);
            // 
            // tileCategory
            // 
            this.tileCategory.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileCategory.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Teal;
            this.tileCategory.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileCategory.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCategory.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileCategory.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.Text = "Category";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileCategory.Elements.Add(tileItemElement2);
            this.tileCategory.Id = 2;
            this.tileCategory.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileCategory.Name = "tileCategory";
            this.tileCategory.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.tileCategory.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCategory_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileNewPL);
            this.tileGroup2.Items.Add(this.tilePakingList);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Packing";
            // 
            // tileNewPL
            // 
            this.tileNewPL.AppearanceItem.Normal.BackColor = System.Drawing.Color.YellowGreen;
            this.tileNewPL.AppearanceItem.Normal.BorderColor = System.Drawing.Color.OliveDrab;
            this.tileNewPL.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNewPL.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNewPL.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileNewPL.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.Text = "New P/L";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileNewPL.Elements.Add(tileItemElement3);
            this.tileNewPL.Id = 3;
            this.tileNewPL.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileNewPL.Name = "tileNewPL";
            this.tileNewPL.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tilePakingList
            // 
            this.tilePakingList.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tilePakingList.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Green;
            this.tilePakingList.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilePakingList.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilePakingList.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tilePakingList.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.Text = "PackingList";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tilePakingList.Elements.Add(tileItemElement4);
            this.tilePakingList.Id = 4;
            this.tilePakingList.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tilePakingList.Name = "tilePakingList";
            this.tilePakingList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tilePakingList_ItemClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Size = new System.Drawing.Size(1272, 770);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tgBaseInfo;
        private DevExpress.XtraEditors.TileItem tileItemCode;
        private DevExpress.XtraEditors.TileItem tileCategory;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileNewPL;
        private DevExpress.XtraEditors.TileItem tilePakingList;
    }
}
