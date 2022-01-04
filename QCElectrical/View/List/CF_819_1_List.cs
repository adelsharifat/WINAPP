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
using QCElectrical.Data;
using Security;

namespace QCElectrical.View.List
{
    public partial class CF_819_1_List : ViewTab
    {
        public CF_819_1_List()
        {
            InitializeComponent();
            ViewTitle = "CF_819_1 List";
        }

        private void CF_819_1_List_ViewLoaded(object sender, EventArgs e)
        {
            //Fill grid on load form
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                grcCF_819_1.SetDataSource(() =>
                {
                    return DAL.Do.FETCH_CF_801_19_1_LIST(LoginInfo.ProjectId);
                });
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void CF_819_1_List_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            e.RibbonPage.AddLiteGridTools(this);
        }
    }
}
