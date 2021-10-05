using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISGenerateHash
{
    public partial class HashGeneratorForm : Form
    {
        public HashGeneratorForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtValue.Text = String.Empty;
                TxtSaltForEncrypt.Text = String.Empty;
                TxtHash.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateHash(TxtValue.Text.Trim(), TxtSaltForEncrypt.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }


        private void GenerateHash(string value, string salt)
        {
            try
            {    
                if(!String.IsNullOrEmpty(TxtValue.Text))
                {
                    TxtHash.Text = Connection.Crypto.Encrypt(value, salt);
                    TxtEncryptedConnectionString.Text = TxtHash.Text;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void DecryptHash(string value, string salt)
        {
            try
            {
                TxtDecrypt.Text = String.Empty;
                TxtDecrypt.Text = Connection.Crypto.Decrypt(value, salt);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateHash(TxtValue.Text.Trim(), TxtSaltForEncrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TxtSalt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateHash(TxtValue.Text.Trim(), TxtSaltForEncrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(TxtHash.Text);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void TxtEncryptedConnectionString_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DecryptHash(TxtEncryptedConnectionString.Text.Trim(), TxtSaltForDecrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnDycrypt_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptHash(TxtEncryptedConnectionString.Text.Trim(), TxtSaltForDecrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnClearDecryptText_Click(object sender, EventArgs e)
        {
            TxtDecrypt.Text = String.Empty;
            TxtEncryptedConnectionString.Text = String.Empty;
            TxtSaltForDecrypt.Text = String.Empty;
        }

        private void TxtEncryptedConnectionString_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DecryptHash(TxtEncryptedConnectionString.Text.Trim(), TxtSaltForDecrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TxtSaltForDecrypt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DecryptHash(TxtEncryptedConnectionString.Text.Trim(), TxtSaltForDecrypt.Text.Trim());
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
