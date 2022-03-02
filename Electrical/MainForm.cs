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

namespace Electrical
{
    public partial class MainForm : CMISRibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            //call inital main form method heree
            InitMainForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.Home>(this);
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
