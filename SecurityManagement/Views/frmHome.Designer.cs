
namespace SecurityManagement.Views
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileUserPermision = new DevExpress.XtraEditors.TileItem();
            this.tileGroupPermision = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(20, 20);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.ShowGroupText = true;
            this.tileControl1.Size = new System.Drawing.Size(1066, 727);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileUserPermision);
            this.tileGroup2.Items.Add(this.tileGroupPermision);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Permision";
            // 
            // tileUserPermision
            // 
            this.tileUserPermision.AppearanceItem.Normal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tileUserPermision.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileUserPermision.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileUserPermision.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileUserPermision.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileUserPermision.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Text = "User Permision";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileUserPermision.Elements.Add(tileItemElement1);
            this.tileUserPermision.Id = 0;
            this.tileUserPermision.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileUserPermision.Name = "tileUserPermision";
            this.tileUserPermision.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileUserPermision_ItemClick);
            // 
            // tileGroupPermision
            // 
            this.tileGroupPermision.AppearanceItem.Normal.BackColor = System.Drawing.Color.DodgerBlue;
            this.tileGroupPermision.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileGroupPermision.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileGroupPermision.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileGroupPermision.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileGroupPermision.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Group Permision";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileGroupPermision.Elements.Add(tileItemElement2);
            this.tileGroupPermision.Id = 1;
            this.tileGroupPermision.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileGroupPermision.Name = "tileGroupPermision";
            this.tileGroupPermision.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileGroupPermision_ItemClick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileControl1);
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowRefreshItem = true;
            this.Size = new System.Drawing.Size(1106, 767);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileUserPermision;
        private DevExpress.XtraEditors.TileItem tileGroupPermision;
    }
}
