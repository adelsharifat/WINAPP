using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUtils;
using Security;
using QCElectrical.Data;
using CMISUIHelper.Infrastructure.Enums;
using DevExpress.XtraEditors;
using CMISDAL.Common;

namespace QCElectrical.View.CF
{
    public partial class frmCF : ViewContainerWithCompany
    {
        public frmCF()
        {
            InitializeComponent();
            ViewTitle = "New CF";
        }

        private void frmCF_Load(object sender, EventArgs e)
        {
            try
            {
                InitComboCompany();
                FillComboCF();
                lblFormState.Text = GetFormModeText();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        public override void InitComboCompany()
        {
            var data = CommonDals.Do.Contract.FetchContractsCombo(LoginInfo.ProjectId, LoginInfo.Id, $"{Bundle.SCHEMA}.Contract");
            this.cmbCompany.Fill(data, "Name", "Id").SelectItem(0).HideColumns("EmployerId,ContractorId");
        }

        public void FillComboCF()
        {
            var data = DAL.Do.FetchCFCombo();
            this.cmbCF.Fill(data, "Name", "Id").HideColumns("FullName,Description");
        }

        private void cmbCF_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblCFFullName.Text = cmbCF.GetColumnValue("FullName").ToString();
                SelectedViewPage(cmbCF);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void SelectedViewPage(LookUpEdit cmbCf)
        {
            switch (cmbCf.Text)
            {
                case "CF-800":
                    CMISUI.UIHandler.ViewInView<CF_800>(this);
                    break;
                case "CF-801-1":
                    CMISUI.UIHandler.ViewInView<CF_801_1>(this);
                    break;
                case "CF-801-3":
                    CMISUI.UIHandler.ViewInView<CF_801_3>(this);
                    break;
                case "CF-806":
                    CMISUI.UIHandler.ViewInView<CF_806>(this);
                    break;
                case "CF-808":
                    CMISUI.UIHandler.ViewInView<CF_808>(this);
                    break;
                case "CF-809":
                    CMISUI.UIHandler.ViewInView<CF_809>(this);
                    break;
                case "CF-810":
                    CMISUI.UIHandler.ViewInView<CF_810>(this);
                    break;
                case "CF-811":
                    CMISUI.UIHandler.ViewInView<CF_811>(this);
                    break;
                case "CF-814":
                    CMISUI.UIHandler.ViewInView<CF_814>(this);
                    break;
                case "CF-816":
                    CMISUI.UIHandler.ViewInView<CF_816>(this);
                    break;
                case "CF-817-1":
                    CMISUI.UIHandler.ViewInView<CF_817_1>(this);
                    break;
                case "CF-817-2":
                    CMISUI.UIHandler.ViewInView<CF_817_2>(this);
                    break;
                case "CF-818":
                    CMISUI.UIHandler.ViewInView<CF_818>(this);
                    break;
                case "CF-819-1":
                    CMISUI.UIHandler.ViewInView<CF_819_1>(this);
                    break;
                case "CF-819-2":
                    CMISUI.UIHandler.ViewInView<CF_819_2>(this);
                    break;
                case "CF-820-1":
                    CMISUI.UIHandler.ViewInView<CF_820_1>(this);
                    break;
                case "CF_820_2":
                    CMISUI.UIHandler.ViewInView<CF_820_2>(this);
                    break;
                case "CF-821-1":
                    CMISUI.UIHandler.ViewInView<CF_821_1>(this);
                    break;
                case "CF-821-2":
                    CMISUI.UIHandler.ViewInView<CF_821_2>(this);
                    break;
                case "CF-823-1":
                    CMISUI.UIHandler.ViewInView<CF_823_1>(this);
                    break;
                case "CF-823-2":
                    CMISUI.UIHandler.ViewInView<CF_823_2>(this);
                    break;
                case "CF-825-1":
                    CMISUI.UIHandler.ViewInView<CF_825_1>(this);
                    break;
                case "CF-837-1":
                    CMISUI.UIHandler.ViewInView<CF_837_1>(this);
                    break;
                case "CF-837-2":
                    CMISUI.UIHandler.ViewInView<CF_837_2>(this);
                    break;
                case "CF-838":
                    CMISUI.UIHandler.ViewInView<CF_838>(this);
                    break;
                case "CF-839":
                    CMISUI.UIHandler.ViewInView<CF_839>(this);
                    break;
                case "CF-840":
                    CMISUI.UIHandler.ViewInView<CF_840>(this);
                    break;
                case "CF-843":
                    CMISUI.UIHandler.ViewInView<CF_843>(this);
                    break;
                case "CF-844":
                    CMISUI.UIHandler.ViewInView<CF_844>(this);
                    break;
                case "CF-845":
                    CMISUI.UIHandler.ViewInView<CF_845>(this);
                    break;
                case "CF-846":
                    CMISUI.UIHandler.ViewInView<CF_846>(this);
                    break;
                case "CF-847":
                    CMISUI.UIHandler.ViewInView<CF_847>(this);
                    break;
                case "CF-849":
                    CMISUI.UIHandler.ViewInView<CF_849>(this);
                    break;
                case "CF-850":
                    CMISUI.UIHandler.ViewInView<CF_850>(this);
                    break;
                case "CF-851":
                    CMISUI.UIHandler.ViewInView<CF_851>(this);
                    break;
                case "CF-852":
                    CMISUI.UIHandler.ViewInView<CF_852>(this);
                    break;
                case "CF-853":
                    CMISUI.UIHandler.ViewInView<CF_853>(this);
                    break;
                case "CF-854":
                    CMISUI.UIHandler.ViewInView<CF_854>(this);
                    break;
                case "CF-855":
                    CMISUI.UIHandler.ViewInView<CF_855>(this);
                    break;
                case "CF-856":
                    CMISUI.UIHandler.ViewInView<CF_856>(this);
                    break;
                case "CF-857":
                    CMISUI.UIHandler.ViewInView<CF_857>(this);
                    break;
                case "CF-858":
                    CMISUI.UIHandler.ViewInView<CF_858>(this);
                    break;
                case "CF-860":
                    CMISUI.UIHandler.ViewInView<CF_860>(this);
                    break;
                case "CF-861":
                    CMISUI.UIHandler.ViewInView<CF_861>(this);
                    break;
            }
        }
    
        private void frmCF_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {
            try
            {
                e.RibbonPage.AddSignTools(this);
                e.RibbonPage.AddLiteGridTools(this);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }
    }
}
