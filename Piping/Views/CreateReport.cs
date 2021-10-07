using CMISUIHelper.Infrastructure.Contracts.CustomAttributes;
using CMISUIHelper.Infrastructure.Extention;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Piping.Infrastructure.Const;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace Piping.Views
{
    [AppSchema(AppConst.Schema)]
    [RibbonMenuItem("Create",1)]
    [RibbonMenuGroup("Group1",1)]
    [RibbonItemIcon(AppConst.ResourceName, "window_32x32")]
    public partial class CreateReport : ViewTab
    {
        public CreateReport()
        {
            InitializeComponent();
            ViewTitle = "Create Report";
        }


        private void CreateReport_RibbonPageAdded(object sender, CMISUIHelper.Infrastructure.Contracts.CustomEventArgs.RibbonPageEventArgs e)
        {

            var itemTest= CMISUI.RibbonHandler.NewItem.ButtonItem("Test","", Test_ItemClick);
            var rpgTest = CMISUI.RibbonHandler.NewRPG("Test").AddItems(itemTest);
            e.RibbonPage.AddGroups(rpgTest);
            itemTest.AddBadge(OwnerForm.BadgeManager).SetText("1").SetLocation(ContentAlignment.MiddleCenter).Properties.Offset = new Point(-5,-5);
            itemTest.AddBadge(OwnerForm.BadgeManager).SetText("1").SetLocation(ContentAlignment.MiddleCenter).Properties.Offset = new Point(-5,-5);

        }

        private void Test_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Worked");
        }

        private void CreateReport_BeforeViewLoad(object sender, EventArgs e)
        {
        
        
        }

        private void CreateReport_ViewLoaded(object sender, EventArgs e)
        {
            
        }
    }
}
