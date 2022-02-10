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
using DevExpress.XtraBars;
using CMISUIHelper.Infrastructure.Helpers;
using Security;
using CMISDAL.Common;
using CMISUtils;
using CMISSecurity;

namespace Electrical.View
{
    public partial class MIVList : ViewTabWithCompany
    {
        public MIVList()
        {
            InitializeComponent();
            ShowRefreshItem = true;
            ViewTitle = "MIV List";
            Grid = grcMIV;
        }

        private void MIVList_BeforeViewLoad(object sender, EventArgs e)
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

        private void MIVList_ViewLoaded(object sender, EventArgs e)
        {

        }

        private void MIVList_ViewRefresh(object sender, EventArgs e)
        {

        }

        private void MIVList_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            e.RibbonPage.AddViewFormActionTool(this);
            e.RibbonPage.AddEditFormActionTool(this);
            e.RibbonPage.AddDeleteFormActionTool(this);

            e.RibbonPage.AddGridTools(this);
            e.RibbonPage.AddExcelExportTool(this);


            // Set Permission
            MenuItems["view"].Enabled =  ACL.ButtonViewMIVDocument.AllowAcl(this);
            MenuItems["edit"].Enabled =  ACL.ButtonEditMIVDocument.AllowAcl(this);
            MenuItems["delete"].Enabled =  ACL.ButtonDeleteMIVDocument.AllowAcl(this);
        }


        #region Form Actions


        #endregion

        #region Helpers
        //Fill contractor combo
        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
                this.cmbCompany.Fill(data, "Contract", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId,Employer,Contractor,EmployerSymbol,ContractorSymbol");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      


        #endregion
    }
}
