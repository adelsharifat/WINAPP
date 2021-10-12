using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper.UserControls
{
    public partial class ViewContainerWithCompany : ViewTabWithCompany
    {
        public Dictionary<string, TabPage> OpenedViews = new Dictionary<string, TabPage>();

        public ViewContainerWithCompany()
        {
            InitializeComponent();
        }
    }
}
