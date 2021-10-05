using CMISUIHelper.Infrastructure.Contracts.CustomEventArgs;
using CMISUIHelper.Infrastructure.Dtos;
using CMISUIHelper.Infrastructure.Extention;
using CMISUIHelper.Infrastructure.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CMISUIHelper.Infrastructure.Helpers.CMISUI;

namespace CMISUIHelper.UserControls
{
    public partial class ViewBase : UserControl
    {
        public Timer ViewLoadTimer = null;
        internal GridControl LastFocucedGrid = null;

        public Dictionary<string,ControlModel> ViewObjects = new Dictionary<string, ControlModel>();
        public Dictionary<string,ControlModel> PermisionViewObjects = new Dictionary<string, ControlModel>();

        public delegate void RibbonPageEventHandler(object sender,RibbonPageEventArgs e = null);
        


        public delegate void ClosingViewEventHandler(object sender, CloseEventArgs e = null);

        public event RibbonPageEventHandler RibbonPageAdded;
        public event ClosingViewEventHandler Closing;
        public event EventHandler BeforeViewLoad;
        public event EventHandler ViewLoaded;
        public event EventHandler ViewRefresh;
        public ViewBase()
        {
            InitializeComponent();
        }

        public void OnRibbonPageAdded(RibbonPageEventArgs e)
        {
            //CMISRibbonForm.ItemIcon = OwnerForm.DefualtItemIcon;

            if (OwnerForm.CloseItemLocation == Infrastructure.Enums.CloseItemAlignment.Start)
            {
                e.RibbonPage.AddCloseItem(this);
                if(e.View.Name != this.OwnerForm.HomePage || this.ShowRefreshItem)
                    e.RibbonPage.AddRefreshItem(this);
            }
                
            this.RibbonPageAdded?.Invoke(e.RibbonPage, e);

            if (OwnerForm.CloseItemLocation == Infrastructure.Enums.CloseItemAlignment.End)
            {
                if (e.View.Name != this.OwnerForm.HomePage || this.ShowRefreshItem)
                    e.RibbonPage.AddRefreshItem(this);
                e.RibbonPage.AddCloseItem(this);
            }
                
        }

        public void OnBeforeViewLoad(EventArgs e)
        {
            this.BeforeViewLoad?.Invoke(this, e);
        }

        public void OnViewLoaded(EventArgs e)
        {
            GetControls(this).ToList().ForEach(x => {
                var objectModel = new ControlModel { Control = x, Type = x.GetType() };
                ViewObjects.Add(objectModel.Name, objectModel);
            });
            
            GetRibbonPageGroups().Where(x => x.Tag != null || x.Tag?.ToString() == String.Empty).ToList().ForEach(x => {
                var objectModel = new ControlModel { Control = x, Type = x.GetType() };
                ViewObjects.Add(objectModel.Name, objectModel);
            });
           
            GetBarItems().Where(x => !String.IsNullOrEmpty(x.Item.AccessibleName)).ToList().ForEach(x => {
                var objectModel = new ControlModel { Control = x, Type = x.GetType() };
                ViewObjects.Add(objectModel.Name, objectModel);
            });
           
            this.ViewObjects.ToList().ForEach(x => {
                if (x.Value.Control is Control)
                {
                    Control control = (Control)Convert.ChangeType(x.Value.Control, x.Value.Type);
                    if (!String.IsNullOrEmpty(control.AccessibleName))
                    {
                        if(this.OwnerForm.Permisions.ToList().Any(a=>a.Key == control.AccessibleName))
                        {
                            switch (this.OwnerForm.Permisions[control.AccessibleName])
                            {
                                case Infrastructure.Enums.PermisionValue.Allow:
                                    control.Enabled = true;
                                    control.Visible = true;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Deny:
                                    control.Enabled = false;
                                    control.Visible = true;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Inherit:
                                    control.Enabled = control.Enabled;
                                    control.Visible = control.Visible;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Hide:
                                    control.Enabled = false;
                                    control.Visible = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                       
                        PermisionViewObjects.Add(x.Value.Name, x.Value);
                    }
                        
                }

                if (x.Value.Control is RibbonPageGroup)
                {
                    RibbonPageGroup control = (RibbonPageGroup)Convert.ChangeType(x.Value.Control, x.Value.Type);
                    if (control.Tag != null || String.IsNullOrEmpty(control.Tag?.ToString()))
                    {
                        if (this.OwnerForm.Permisions.ToList().Any(a => a.Key == control.Tag?.ToString()))
                        {
                            switch (this.OwnerForm.Permisions[control.Tag?.ToString()])
                            {
                                case Infrastructure.Enums.PermisionValue.Allow:
                                    control.Enabled = true;
                                    control.Visible = true;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Deny:
                                    control.Enabled = false;
                                    control.Visible = true;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Inherit:
                                    control.Enabled = control.Enabled;
                                    control.Visible = control.Visible;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Hide:
                                    control.Enabled = false;
                                    control.Visible = false;
                                    break;
                                default:
                                    break;
                            }
                        }


                        PermisionViewObjects.Add(x.Value.Name, x.Value);
                    }
                }

                if (x.Value.Control is BarItemLink)
                {
                    BarItemLink control = (BarItemLink)Convert.ChangeType(x.Value.Control, x.Value.Type);
                    if (!String.IsNullOrEmpty(control.Item.AccessibleName))
                    {
                        if (this.OwnerForm.Permisions.ToList().Any(a => a.Key == control.Item.AccessibleName))
                        {
                            switch (this.OwnerForm.Permisions[control.Item.AccessibleName])
                            {
                                case Infrastructure.Enums.PermisionValue.Allow:
                                    control.Item.Enabled = true;
                                    control.Item.Visibility = BarItemVisibility.Always;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Deny:
                                    control.Item.Enabled = false;
                                    control.Item.Visibility = BarItemVisibility.Always;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Inherit:
                                    control.Item.Enabled = control.Enabled;
                                    control.Item.Visibility = control.Item.Visibility;
                                    break;
                                case Infrastructure.Enums.PermisionValue.Hide:
                                    var rpg = RibbonPage.Groups.FirstOrDefault(g=>g.ItemLinks.Any(i=> i.Caption == control.Caption));
                                    if (rpg?.ItemLinks.Count == 1)
                                        rpg.Visible = false;
                                    control.Item.Enabled = false;
                                    control.Item.Visibility = BarItemVisibility.Never;
                                    break;
                                default:
                                    break;
                            }
                        }
                        PermisionViewObjects.Add(x.Value.Name, x.Value);
                    }
                }
            });
            
            this.ViewLoaded?.Invoke(this, e);
        }

        private bool closeCancel = false;
        public void OnViewClosing(CloseEventArgs e)
        {
            this.Closing?.Invoke(this, e);
            closeCancel = e.Cancel;
        }

        public void OnViewClose(EventArgs e)
        {
            if (closeCancel) return;
            this.Close();
        }


        public void OnViewRefresh(EventArgs e)
        {
            this.ViewRefresh?.Invoke(this, e);
        }

        private IEnumerable<Control> GetControls(Control control)
        {
            var controls = control.Controls.OfType<Control>();
            return controls.SelectMany(ctrl => GetControls(ctrl))
                           .Concat(controls);
        }

        private IEnumerable<RibbonPageGroup> GetRibbonPageGroups() => RibbonPage.Groups.ToList();

        private IEnumerable<BarItemLink> GetBarItems()
        {
            List<BarItemLink> barItems = new List<BarItemLink>();
            RibbonPage.Groups.ToList().ForEach(x=>barItems.AddRange(x.ItemLinks.ToList()));
            return barItems;        
        }

        private void Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public string ViewTitle { get; set; }
        public CMISRibbonForm OwnerForm { get; set; }
        public RibbonPage RibbonPage { get; set; }
        public TabPage TabPage { get; set; }
        public TabControl TabControl { get; set; }
        public string ViewIdentity { get => Guid.NewGuid().ToString("N").Substring(10); }

        #region ExtraCMISCode

        #region Properties

        private bool showRefreshItem = false;

        public bool ShowRefreshItem
        {
            get { return showRefreshItem; }
            set { showRefreshItem = value; }
        }



        private Bitmap gridToolsSearchIcon = UIHelperResources.zoom_32x32;

        public Bitmap GridToolsSearchIcon
        {
            get { return gridToolsSearchIcon; }
            set { gridToolsSearchIcon  = value; }
        }

        private Bitmap gridToolsAutoWidthIcon = UIHelperResources.autofittogrid_32x32;

        public Bitmap GridToolsAutoWidthIcon
        {
            get { return gridToolsAutoWidthIcon; }
            set { gridToolsAutoWidthIcon = value; }
        }

        private Bitmap gridToolsBestFitIcon = UIHelperResources.columnautowidth_32x32;

        public Bitmap GridToolsBestFitIcon
        {
            get { return gridToolsBestFitIcon; }
            set { gridToolsBestFitIcon = value; }
        }


        private Bitmap gridToolsDateFormatIcon = UIHelperResources.calendar_32x32;

        public Bitmap GridToolsDateFormatIcon
        {
            get { return gridToolsDateFormatIcon; }
            set { gridToolsBestFitIcon = value; }
        }

        private Bitmap gridToolsColorFormatIcon = UIHelperResources.palette_32x32;

        public Bitmap GridToolsColorFormatIcon
        {
            get { return gridToolsColorFormatIcon; }
            set { gridToolsColorFormatIcon = value; }
        }

        private Bitmap gridToolsResetGridFormatIcon = UIHelperResources.cleartablestyle_32x32;

        public Bitmap GridToolsResetGridFormatIcon
        {
            get { return gridToolsResetGridFormatIcon; }
            set { gridToolsResetGridFormatIcon = value; }
        }

        private Bitmap gridToolsSettingsGridFormatIcon = UIHelperResources.format_32x32;

        public Bitmap GridToolsSettingsGridFormatIcon
        {
            get { return gridToolsSettingsGridFormatIcon; }
            set { gridToolsSettingsGridFormatIcon = value; }
        }

        private Bitmap gridToolsExportToXlsxIcon = UIHelperResources.exporttoxlsx_32x32;

        public Bitmap GridToolsExportToXlsxIcon
        {
            get { return gridToolsExportToXlsxIcon; }
            set { gridToolsExportToXlsxIcon = value; }
        }

        private Bitmap gridToolsExportToCsvIcon = UIHelperResources.exporttocsv_32x32;

        public Bitmap GridToolsExportToCsvIcon
        {
            get { return gridToolsExportToCsvIcon; }
            set { gridToolsExportToCsvIcon = value; }
        }

        private Bitmap gridToolsExportToPdfIcon = UIHelperResources.exporttopdf_32x32;

        public Bitmap GridToolsExportToPdfIcon
        {
            get { return gridToolsExportToPdfIcon; }
            set { gridToolsExportToPdfIcon = value; }
        }

        #endregion

        #region Methods


        public void Close()
        {
            if (IsHomePage() && this.TabControl.TabPages.Count > 1) return;

            if(this.TabControl.TabPages.Count<=1)
            {
                this.OwnerForm.Close();
                return;
            }

            var previeosTabPageIndex = (TabControl.TabPages.IndexOf(this.TabPage) - 1) < 0 ? 0 : TabControl.TabPages.IndexOf(this.TabPage) - 1;
            this.TabPage.Dispose();
            this.RibbonPage.Dispose();
            this.TabControl.SelectedIndex = previeosTabPageIndex;
        }

        public bool IsHomePage()
        {
            if (this.Name == this.OwnerForm.HomePage) return true;
            return false;
        }
        #endregion

        #endregion
    }
}
