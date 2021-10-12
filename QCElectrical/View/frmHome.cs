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

namespace QCElectrical.View
{
    public partial class frmHome : ViewTab
    {
        public frmHome()
        {
            InitializeComponent();
            ViewTitle = "Home";
        }

        private void tileCFItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.BaseInfo.frmCFItem>(this.OwnerForm);
        }

        private void tileNewCF_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.CF.frmCF>(this.OwnerForm);
        }

        private void tileCFList_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.List.frmCFList>(this.OwnerForm);
        }

        private void tileCFReport_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CMISUI.UIHandler.ViewInTab<View.Report.frmCFReport>(this.OwnerForm);
        }

        private void frmHome_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
