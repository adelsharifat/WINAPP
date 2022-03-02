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

namespace SecurityManagement.Main
{
    public partial class frmMain : CMISRibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitMainForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<Views.frmHome>(this);
        }

        //Initial main form
        private void InitMainForm()
        {
            Schema = Bundle.SCHEMA;
            Version = Bundle.VERSION;
            InitAvatar();
            Ribbon.ApplicationButtonText = Bundle.APPNAME;
            CloseItemLocation = CMISUIHelper.Infrastructure.Enums.CloseItemAlignment.Start;
        }
    }
}
