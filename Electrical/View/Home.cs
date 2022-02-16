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
            ShowRefreshItem = false;
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

        private void tilePakingList_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.PackingList>(this.OwnerForm);
        }

        private void tileMTO_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.MTO>(this.OwnerForm);
        }

        private void tileNewMiv_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.MIV>(this.OwnerForm);
        }

        private void tileMIVList_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.MIVList>(this.OwnerForm);
        }

        private void tileMonitoring_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.Monitoring>(this.OwnerForm);
        }
    }
}
