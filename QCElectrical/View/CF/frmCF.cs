using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUtils;
using Security;
using QCElectrical.Data;
using CMISUIHelper.Infrastructure.Enums;
using DevExpress.XtraEditors;
using CMISDAL.Common;

namespace QCElectrical.View.CF
{
    public partial class frmCF : ViewTab
    {
        public frmCF()
        {
            InitializeComponent();
            ViewTitle = "New CF";
        }

        private void frmCF_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.CF.CF_819_1>(this.OwnerForm);
        }
    }
}
