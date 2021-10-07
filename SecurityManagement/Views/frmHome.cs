using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManagement.Views
{
    public partial class frmHome : ViewTab
    {
        public frmHome()
        {
            InitializeComponent();
            ViewTitle = "Home";
        }

        private void tileUserPermision_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<Views.frmUserPermision>(this.OwnerForm);
        }

        private void tileGroupPermision_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<Views.frmPermisionGroup>(this.OwnerForm);
        }
    }
}
