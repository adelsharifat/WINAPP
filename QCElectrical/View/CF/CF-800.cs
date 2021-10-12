using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;

namespace QCElectrical.View.CF
{
    public partial class CF_800 : ViewTab
    {
        public CF_800()
        {
            InitializeComponent();
        }

        private void CF_800_ViewLoaded(object sender, EventArgs e)
        {
            try
            {
                this.RibbonPage.AddExportTools(this.OwnerView);
                var frmCF = (View.CF.frmCF)this.OwnerView;
                lblCFDescription.Text = frmCF.cmbCF.GetColumnValue("Description").ToString();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
