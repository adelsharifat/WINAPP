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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<Views.frmHome>(this);
        }
    }
}
