using CMISUIHelper;
using CMISUIHelper.Infrastructure.Helpers;
using Piping.Infrastructure.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piping.Main
{
    public partial class MainForm : CMISRibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            Schema = AppConst.Schema;            
            ShowHomeMenuItems = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<Views.Home>(this);
        }
    }
}
