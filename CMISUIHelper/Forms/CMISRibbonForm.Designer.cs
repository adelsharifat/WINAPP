
namespace CMISUIHelper
{
    partial class CMISRibbonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMISRibbonForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.MainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpPopup = new DevExpress.XtraBars.PopupMenu();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAvatar = new DevExpress.XtraBars.BarButtonItem();
            this.AvatarPopup = new DevExpress.XtraBars.PopupMenu();
            this.btnChangeAvatar = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.BBICloseApp = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.MainStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.MainTabControl = new CMISUIHelper.UserControls.CMTabControl();
            this.BadgeManager = new DevExpress.Utils.VisualEffects.AdornerUIManager();
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRibbon
            // 
            this.MainRibbon.AllowKeyTips = false;
            this.MainRibbon.AllowMdiChildButtons = false;
            this.MainRibbon.AllowMinimizeRibbon = false;
            this.MainRibbon.AllowTrimPageText = false;
            this.MainRibbon.ApplicationButtonText = "APPNAME";
            this.MainRibbon.CaptionBarItemLinks.Add(this.barStaticItem1);
            this.MainRibbon.CaptionBarItemLinks.Add(this.barButtonItem4);
            this.MainRibbon.CaptionBarItemLinks.Add(this.barBtnAvatar);
            this.MainRibbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.MainRibbon.ExpandCollapseItem.Id = 0;
            this.MainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem4,
            this.barBtnAvatar,
            this.MainRibbon.ExpandCollapseItem,
            this.BBICloseApp,
            this.btnChangeAvatar,
            this.btnChangePassword,
            this.btnHelp,
            this.btnAbout});
            this.MainRibbon.Location = new System.Drawing.Point(0, 0);
            this.MainRibbon.MaxItemId = 13;
            this.MainRibbon.Name = "MainRibbon";
            this.MainRibbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemHypertextLabel1});
            this.MainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.MainRibbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.MainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.MainRibbon.ShowItemCaptionsInCaptionBar = true;
            this.MainRibbon.ShowToolbarCustomizeItem = false;
            this.MainRibbon.Size = new System.Drawing.Size(1245, 54);
            this.MainRibbon.StatusBar = this.MainStatusBar;
            this.MainRibbon.Toolbar.ShowCustomizeItem = false;
            this.MainRibbon.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.MainRibbon_SelectedPageChanging);
            this.MainRibbon.SelectedPageChanged += new System.EventHandler(this.MainRibbon_SelectedPageChanged);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "CMIS";
            this.barStaticItem1.Id = 10;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.ShowImageInToolbar = false;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.AllowDrawArrow = false;
            this.barButtonItem4.AllowDrawArrowInMenu = false;
            this.barButtonItem4.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.DropDownControl = this.HelpPopup;
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // HelpPopup
            // 
            this.HelpPopup.ItemLinks.Add(this.btnHelp);
            this.HelpPopup.ItemLinks.Add(this.btnAbout);
            this.HelpPopup.Name = "HelpPopup";
            this.HelpPopup.Ribbon = this.MainRibbon;
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Help";
            this.btnHelp.Id = 11;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.LargeImage")));
            this.btnHelp.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ShortcutKeyDisplayString = "F1";
            this.btnHelp.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHelp_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 12;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.LargeImage")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // barBtnAvatar
            // 
            this.barBtnAvatar.ActAsDropDown = true;
            this.barBtnAvatar.AllowDrawArrow = false;
            this.barBtnAvatar.AllowDrawArrowInMenu = false;
            this.barBtnAvatar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barBtnAvatar.DropDownControl = this.AvatarPopup;
            this.barBtnAvatar.Id = 3;
            this.barBtnAvatar.ItemAppearance.Normal.Options.UseImage = true;
            this.barBtnAvatar.Name = "barBtnAvatar";
            this.barBtnAvatar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // AvatarPopup
            // 
            this.AvatarPopup.ItemLinks.Add(this.btnChangeAvatar);
            this.AvatarPopup.ItemLinks.Add(this.btnChangePassword);
            this.AvatarPopup.Name = "AvatarPopup";
            this.AvatarPopup.Ribbon = this.MainRibbon;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Caption = "Change Profile Photo";
            this.btnChangeAvatar.Id = 4;
            this.btnChangeAvatar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAvatar.ImageOptions.Image")));
            this.btnChangeAvatar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangeAvatar.ImageOptions.LargeImage")));
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeAvatar_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Change Passsword";
            this.btnChangePassword.Id = 5;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // BBICloseApp
            // 
            this.BBICloseApp.Caption = "Close";
            this.BBICloseApp.Id = 1;
            this.BBICloseApp.Name = "BBICloseApp";
            this.BBICloseApp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Close Application";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Close all opened form and application";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.BBICloseApp.SuperTip = superToolTip1;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Caption.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.repositoryItemPictureEdit1.Caption.Text = "یبلیبل";
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = " ";
            this.repositoryItemPictureEdit1.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.repositoryItemPictureEdit1.ShowMenu = false;
            this.repositoryItemPictureEdit1.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Location = new System.Drawing.Point(0, 727);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Ribbon = this.MainRibbon;
            this.MainStatusBar.Size = new System.Drawing.Size(1245, 21);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.MainTabControl.Location = new System.Drawing.Point(0, 54);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1245, 673);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            this.MainTabControl.TabIndexChanged += new System.EventHandler(this.MainTabControl_TabIndexChanged);
            // 
            // BadgeManager
            // 
            this.BadgeManager.Owner = this;
            // 
            // CMISRibbonForm
            // 
            this.ClientSize = new System.Drawing.Size(1245, 748);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainRibbon);
            this.MinimumSize = new System.Drawing.Size(1247, 749);
            this.Name = "CMISRibbonForm";
            this.Ribbon = this.MainRibbon;
            this.StatusBar = this.MainStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbon;
        private DevExpress.XtraBars.BarButtonItem BBICloseApp;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar MainStatusBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarButtonItem barBtnAvatar;
        private DevExpress.XtraBars.BarButtonItem btnChangeAvatar;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.PopupMenu AvatarPopup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.PopupMenu HelpPopup;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private UserControls.CMTabControl MainTabControl;
        public DevExpress.Utils.VisualEffects.AdornerUIManager BadgeManager;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
    }
}
