using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using CMISUIHelper.Infrastructure.Helpers;

namespace QCElectrical.View.Attachment
{
    public partial class AttachmentUploader : ViewForm
    {
        const string AdditionalOpenFileDialogFilter = "JPEG Image(*.jpg)|*.jpg,PNG Image(*.png)|*.png,BMP Image(*.bmp)|*.bmp";

        public string FilePath { get; set; }
        public string Remark { get; set; }

        public AttachmentUploader()
        {
            InitializeComponent();
            ViewTitle = "Import Attachment";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DMS.Attachment.Do.OpenFileDialog(txtFilePath, txtRemark,AdditionalOpenFileDialogFilter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                FilePath = txtFilePath.Text;
                Remark = txtRemark.Text;
                this.OwnerForm.DialogResult = DialogResult.OK;
                this.OwnerForm.Close();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
