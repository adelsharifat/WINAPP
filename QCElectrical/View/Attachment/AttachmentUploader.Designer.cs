namespace QCElectrical.View.Attachment
{
    partial class AttachmentUploader
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
            this.txtFilePath = new DevExpress.XtraEditors.TextEdit();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAttachment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(20, 30);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Properties.Appearance.Options.UseFont = true;
            this.txtFilePath.Properties.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(399, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ImageOptions.Image = global::QCElectrical.Properties.Resources.open_16x16;
            this.btnBrowse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBrowse.ImageOptions.ImageToTextIndent = 8;
            this.btnBrowse.Location = new System.Drawing.Point(425, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 26);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(20, 93);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemark.Size = new System.Drawing.Size(501, 96);
            this.txtRemark.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remark";
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.ImageOptions.Image = global::QCElectrical.Properties.Resources.Plus;
            this.btnAddAttachment.Location = new System.Drawing.Point(20, 195);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(113, 26);
            this.btnAddAttachment.TabIndex = 4;
            this.btnAddAttachment.Text = "Add Attachment";
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // AttachmentUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "AttachmentUploader";
            this.Size = new System.Drawing.Size(542, 240);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtFilePath;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAddAttachment;
    }
}
