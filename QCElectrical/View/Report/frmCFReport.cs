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
using CMISDAL.Common;
using CMISUtils;

namespace QCElectrical.View.Report
{
    public partial class frmCFReport : ViewTab
    {
        public frmCFReport()
        {
            InitializeComponent();
            ViewTitle = "CF Report";
        }

        private void frmCFReport_ViewLoaded(object sender, EventArgs e)
        {

        }
    }
}
