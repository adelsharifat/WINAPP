using CMISUIHelper.Infrastructure.Contracts.CustomAttributes;
using CMISUIHelper.UserControls;
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

namespace Piping.Views
{
    [AppSchema(AppConst.Schema)]
    [RibbonMenuItem("Report List", 2)]
    [RibbonMenuGroup("Group2", 0)]
    [RibbonItemIcon(AppConst.ResourceName, "window_32x32")]
    public partial class ReportList : ViewBase
    {
        public ReportList()
        {
            InitializeComponent();
            ViewTitle = "Report List";
        }
    }
}
