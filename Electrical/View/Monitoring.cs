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
using Electrical.Data;
using Security;
using CMISUtils.Extentions;
using CMISDAL.Common;
using CMISUtils;

namespace Electrical.View
{
    public partial class Monitoring : ViewTabWithCompany
    {
        public Monitoring()
        {
            InitializeComponent();
            ShowRefreshItem = true;
            ViewTitle = "Monitoring";
            Grid = grcMonitoring;
        }

        private void Monitoring_BeforeViewLoad(object sender, EventArgs e)
        {

        }

        private void Monitoring_ViewLoaded(object sender, EventArgs e)
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

        private void Monitoring_ViewRefresh(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void Monitoring_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            e.RibbonPage.AddGridTools(this);
            e.RibbonPage.AddExcelExportTool(this);

        }


        private void FillGrid()
        {
            try
            {
                var data = DAL.Do.GetMonitoring(LoginInfo.ProjectId,LoginInfo.Id,cmbCompany.EditValue.ToInt());
                grcMonitoring.DataSource = data;
                //grcMonitoring.SetDataSource(() => data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void InitComboCompany()
        {
            try
            {
                var data = CommonDals.Do.Company.FetchCompaniesCombo(LoginInfo.Id, LoginInfo.ProjectId,  $"{Bundle.SCHEMA}.Company");
                this.cmbCompany.Fill(data, "FullName", "Id").SelectItem(0).HideColumns("Symbol");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbCompany_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
