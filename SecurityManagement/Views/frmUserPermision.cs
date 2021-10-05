using CMISDAL.Common;
using CMISUIHelper.Infrastructure.Contracts.CustomAttributes;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using CMISUtils;
using DevExpress.XtraGrid.Views.Grid;
using SecurityManagement.Data;
using SecurityManagement.Infrastructure.Const;
using SecurityManagement.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SecurityManagement.Views
{
    [AppSchema(AppConst.Schema)]
    [RibbonMenuItem("User Permision", 1)]
    [RibbonMenuGroup("Permision", 1)]
    [RibbonItemIcon(AppConst.ResourceName, "window_32x32")]
    public partial class frmUserPermision : CMISView
    {
        public frmUserPermision()
        {
            InitializeComponent();
            ViewTitle = "User Permision";            
        }
    }
}
