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
using CMISDAL.Common;
using Security;
using CMISUtils;

namespace Electrical.View
{
    public partial class Packing : ViewTabWithCompany
    {
        public Packing()
        {
            InitializeComponent();
        }

        private void Packing_BeforeViewLoad(object sender, EventArgs e)
        {
            try
            {
                InitComboCompany();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Packing_ViewLoaded(object sender, EventArgs e)
        {

        }

        private void Packing_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void Packing_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            var btnNewItem = e.RibbonPage.AddNewFormActionTool(this);
            var btnSaveItem = e.RibbonPage.AddSaveFormActionTool(this);
            var btnEditItem = e.RibbonPage.AddEditFormActionTool(this);
            var btnDelete = e.RibbonPage.AddDeleteFormActionTool(this);

            var btnPostItem = e.RibbonPage.AddSignPostActionTool(this);

        }


        #region Overrided
        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
                this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion



        //Form helper functions
        private void LoadData()
        {

        }

        //Fill packing list grid
        private void FillPackingListGrid()
        {

        }

    }
}
