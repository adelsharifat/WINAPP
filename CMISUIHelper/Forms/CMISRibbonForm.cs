using CMISUIHelper.Infrastructure.Contracts;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.Infrastructure.Helpers;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper
{
    public partial class CMISRibbonForm : RibbonForm
    {
        public Dictionary<string, TabPage> OpenTabs = new Dictionary<string, TabPage>();
        public Dictionary<string, PermisionValue> Permisions = new Dictionary<string, PermisionValue>();

        public CMISRibbonForm()
        {
            InitializeComponent();
            if (!DesignMode)
                GetUserPermisons(1, 2);
            ItemIcon = this.DefualtItemIcon;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Ribbon.SelectedPage = this.Ribbon.Pages.FirstOrDefault(p => p.Name == MainTabControl.SelectedTab.Name);
        }

        private void MainTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            var currentTab = MainTabControl.SelectedTab;
            this.Ribbon.SelectedPage = this.Ribbon.Pages.FirstOrDefault(p => p.Name == currentTab.Name);
        }
        #region Properties
        private string schema;
        public string Schema
        {
            get { return schema; }
            set { schema = value; }
        }


        private bool showHomeMenuItems = false;
        public bool ShowHomeMenuItems
        {
            get { return showHomeMenuItems; }
            set { showHomeMenuItems = value; }
        }


        private string uerName;
        public string UserName
        {
            get { return uerName; }
            set { uerName = value; }
        }

        private string homePage;
        public string HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }



        private CloseItemAlignment closeItemLocation = CloseItemAlignment.Start;
        public CloseItemAlignment CloseItemLocation
        {
            get { return closeItemLocation; }
            set { closeItemLocation = value; }
        }


        private bool showPreloadingOnViews = false;

        public bool ShowPreloadingOnViews
        {
            get { return showPreloadingOnViews; }
            set { showPreloadingOnViews = value; }
        }


        private Image ribbonPageIcon;

        public Image RibbonPageIcon
        {
            get { return ribbonPageIcon; }
            set { ribbonPageIcon = value; }
        }


        private Image closeIcon = UIHelperResources.close_32x32;

        public Image CloseIcon
        {
            get { return closeIcon; }
            set { closeIcon = value; }
        }

        private Image refreshIcon = UIHelperResources.refresh_32x32;

        public Image RefreshIcon
        {
            get { return refreshIcon; }
            set { refreshIcon = value; }
        }


        public static Image ItemIcon;
        private Image defualtItemIcon = UIHelperResources.DefulatItemIcon;

        public  Image DefualtItemIcon
        {
            get { return defualtItemIcon; }
            set { defualtItemIcon = value; }
        }



        #endregion

        #region Method
        private void GetUserPermisons(int projectId,int userId)
        {
            Permisions.Add("ShowAll", PermisionValue.Deny);
            Permisions.Add("CloseForm", PermisionValue.Allow);
            Permisions.Add("Test", PermisionValue.Allow);
            Permisions.Add("datetimepicker", PermisionValue.Deny);
        }







        #endregion

        private void MainRibbon_SelectedPageChanged(object sender, EventArgs e)
        {
            var tab = OpenTabs[Ribbon.SelectedPage.Name];
            MainTabControl.SelectedTab = tab;
        }

        private void MainRibbon_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {
            
        }
    }
}
