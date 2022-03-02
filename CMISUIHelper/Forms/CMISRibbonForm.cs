using CMISDAL.Common;
using CMISUIHelper.Infrastructure.Contracts;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.Infrastructure.Helpers;
using CMISUtils;
using CommonClass;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using Security;
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
            ItemIcon = this.DefualtItemIcon;
            Icon = UIHelperResources._32x32;
            GetUserPermissions(LoginInfo.ProjectId,LoginInfo.Id);                      
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
        private string version;
        public string Version
        {
            get { return version; }
            set { version = value; }
        }



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
        private void GetUserPermissions(int projectId,int userId)
        {
            var data = CommonDals.Do.Permision.FetchUserPermission(projectId, userId);
            foreach (DataRow acl in data.Rows)
            {
                PermisionValue Allow = PermisionValue.Deny;
                switch ((int?)Convert.ToInt32(acl["Allow"]))
                {
                    case 0:
                        Allow = PermisionValue.Deny;
                        break;
                    case 1:
                        Allow = PermisionValue.Allow;
                        break;
                    case -1:
                        Allow = PermisionValue.Hide;
                        break;
                    case null:
                        Allow = PermisionValue.Inherit;
                        break;

                    default:
                        break;
                }

                Permisions.Add(acl["Name"].ToString(), Allow);
            }
        }

        public void InitAvatar()
        {
            CMISBEL.Core.Common.belUser belUser = new CMISBEL.Core.Common.belUser();
            barBtnAvatar.ImageOptions.Image = belUser.FetchAvatarByUserId(LoginInfo.Id).ResizeImage(16, 16);
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

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnChangePassword();
        }

        public virtual void OnChangePassword()
        {
            Msg.Show("In Progress...");
        }


        public virtual void OnChangeAvatar()
        {
            Msg.Show("In Progress...");
        }

        public virtual void OnAbout()
        {
            Msg.Show("In Progress...");
        }

        public virtual void OnHelp()
        {
            Msg.Show("In Progress...");
        }


        private void btnChangeAvatar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnChangeAvatar();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnAbout();
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnHelp();
        }

        private void CMISRibbonForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode) {
                sbFullName.Caption = LoginInfo.FullName;
                sbjobTitle.Caption = LoginInfo.JobTitle;
                sbLastLogin.Caption = LoginInfo.LastLogin.ToString();
                sbProject.Caption = LoginInfo.ProjectName;
                sbVersion.Caption = this.Version;
            };
        }
    }
}
