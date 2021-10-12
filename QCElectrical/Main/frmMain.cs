using CMISUIHelper;
using CMISUIHelper.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCElectrical.Main
{
    public partial class frmMain : CMISRibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                CMISUI.UIHandler.ViewInTab<View.frmHome>(this);
                InitAvatar();
                this.Ribbon.ApplicationButtonText = "QC ELECTRICAL";

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        public override void OnChangePassword()
        {
            //base.OnChangePassword();
            Msg.Show("In Progress...2");
        }
    }
}
