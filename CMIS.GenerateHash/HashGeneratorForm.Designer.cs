namespace CMISGenerateHash
{
    partial class HashGeneratorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSaltForEncrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHash = new System.Windows.Forms.TextBox();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDecrypt = new System.Windows.Forms.TextBox();
            this.BtnCopyToClipboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClearDecryptText = new System.Windows.Forms.Button();
            this.BtnDycrypt = new System.Windows.Forms.Button();
            this.TxtSaltForDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEncryptedConnectionString = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(20, 52);
            this.TxtValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtValue.Multiline = true;
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(434, 58);
            this.TxtValue.TabIndex = 0;
            this.TxtValue.TextChanged += new System.EventHandler(this.TxtValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salt";
            // 
            // TxtSaltForEncrypt
            // 
            this.TxtSaltForEncrypt.Location = new System.Drawing.Point(20, 146);
            this.TxtSaltForEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSaltForEncrypt.Multiline = true;
            this.TxtSaltForEncrypt.Name = "TxtSaltForEncrypt";
            this.TxtSaltForEncrypt.Size = new System.Drawing.Size(434, 27);
            this.TxtSaltForEncrypt.TabIndex = 2;
            this.TxtSaltForEncrypt.TextChanged += new System.EventHandler(this.TxtSalt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encrypt";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtHash
            // 
            this.TxtHash.Location = new System.Drawing.Point(20, 210);
            this.TxtHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHash.Multiline = true;
            this.TxtHash.Name = "TxtHash";
            this.TxtHash.ReadOnly = true;
            this.TxtHash.Size = new System.Drawing.Size(434, 78);
            this.TxtHash.TabIndex = 4;
            this.TxtHash.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(20, 296);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(134, 35);
            this.BtnEncrypt.TabIndex = 6;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(160, 296);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(60, 35);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(392, 317);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(62, 35);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Decrypt";
            // 
            // TxtDecrypt
            // 
            this.TxtDecrypt.Location = new System.Drawing.Point(20, 247);
            this.TxtDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDecrypt.Multiline = true;
            this.TxtDecrypt.Name = "TxtDecrypt";
            this.TxtDecrypt.ReadOnly = true;
            this.TxtDecrypt.Size = new System.Drawing.Size(434, 62);
            this.TxtDecrypt.TabIndex = 9;
            // 
            // BtnCopyToClipboard
            // 
            this.BtnCopyToClipboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyToClipboard.Location = new System.Drawing.Point(356, 296);
            this.BtnCopyToClipboard.Name = "BtnCopyToClipboard";
            this.BtnCopyToClipboard.Size = new System.Drawing.Size(98, 35);
            this.BtnCopyToClipboard.TabIndex = 11;
            this.BtnCopyToClipboard.Text = "Copy";
            this.BtnCopyToClipboard.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnCopyToClipboard);
            this.groupBox1.Controls.Add(this.TxtValue);
            this.groupBox1.Controls.Add(this.TxtSaltForEncrypt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.TxtHash);
            this.groupBox1.Controls.Add(this.BtnEncrypt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 342);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Encrypt   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtEncryptedConnectionString);
            this.groupBox2.Controls.Add(this.BtnClearDecryptText);
            this.groupBox2.Controls.Add(this.BtnDycrypt);
            this.groupBox2.Controls.Add(this.TxtSaltForDecrypt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDecrypt);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 375);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Decrypt   ";
            // 
            // BtnClearDecryptText
            // 
            this.BtnClearDecryptText.Location = new System.Drawing.Point(160, 317);
            this.BtnClearDecryptText.Name = "BtnClearDecryptText";
            this.BtnClearDecryptText.Size = new System.Drawing.Size(60, 35);
            this.BtnClearDecryptText.TabIndex = 12;
            this.BtnClearDecryptText.Text = "Clear";
            this.BtnClearDecryptText.UseVisualStyleBackColor = true;
            this.BtnClearDecryptText.Click += new System.EventHandler(this.BtnClearDecryptText_Click);
            // 
            // BtnDycrypt
            // 
            this.BtnDycrypt.Location = new System.Drawing.Point(20, 317);
            this.BtnDycrypt.Name = "BtnDycrypt";
            this.BtnDycrypt.Size = new System.Drawing.Size(134, 35);
            this.BtnDycrypt.TabIndex = 14;
            this.BtnDycrypt.Text = "Decrypt";
            this.BtnDycrypt.UseVisualStyleBackColor = true;
            this.BtnDycrypt.Click += new System.EventHandler(this.BtnDycrypt_Click);
            // 
            // TxtSaltForDecrypt
            // 
            this.TxtSaltForDecrypt.Location = new System.Drawing.Point(20, 181);
            this.TxtSaltForDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSaltForDecrypt.Multiline = true;
            this.TxtSaltForDecrypt.Name = "TxtSaltForDecrypt";
            this.TxtSaltForDecrypt.Size = new System.Drawing.Size(434, 27);
            this.TxtSaltForDecrypt.TabIndex = 12;
            this.TxtSaltForDecrypt.TextChanged += new System.EventHandler(this.TxtSaltForDecrypt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Encrypted Connection String";
            // 
            // TxtEncryptedConnectionString
            // 
            this.TxtEncryptedConnectionString.Location = new System.Drawing.Point(20, 59);
            this.TxtEncryptedConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEncryptedConnectionString.Multiline = true;
            this.TxtEncryptedConnectionString.Name = "TxtEncryptedConnectionString";
            this.TxtEncryptedConnectionString.Size = new System.Drawing.Size(434, 78);
            this.TxtEncryptedConnectionString.TabIndex = 15;
            this.TxtEncryptedConnectionString.TextChanged += new System.EventHandler(this.TxtEncryptedConnectionString_TextChanged_1);
            // 
            // HashGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 800);
            this.Name = "HashGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSaltForEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHash;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDecrypt;
        private System.Windows.Forms.Button BtnCopyToClipboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDycrypt;
        private System.Windows.Forms.TextBox TxtSaltForDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClearDecryptText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEncryptedConnectionString;
    }
}

