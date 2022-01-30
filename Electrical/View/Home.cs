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
using CMISUIHelper.Infrastructure.Helpers;

namespace Electrical.View
{
    public partial class Home : ViewTab
    {
        public Home()
        {
            InitializeComponent();
            ViewTitle = AppConfig.Home_View_Title;
        }

        private void tileItemCode_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.ItemCode>(this.OwnerForm);
        }

        private void tileCategory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.Category>(this.OwnerForm);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.Packing>(this.OwnerForm);
        }
    }
}
