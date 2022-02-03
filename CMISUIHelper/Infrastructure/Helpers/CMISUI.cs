using CMISUIHelper.Infrastructure.Contracts.CustomAttributes;
using CMISUIHelper.Infrastructure.Contracts.CustomEventArgs;
using CMISUIHelper.Infrastructure.Contracts.CustomException;
using CMISUIHelper.Infrastructure.Dtos;
using CMISUIHelper.Infrastructure.Enums;
using CMISUIHelper.UserControls;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CMISUIHelper.Infrastructure.Helpers
{
    public static class Msg
    {
        public static DialogResult Confirm(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        public static void Show(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Info(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static DialogResult Question(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        public static DialogResult Warning(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        public static void Error(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Stop(string text, string title = "CMIS Message") => MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        public static Action ConfirmOperation(string txt,string title = "CMIS Message")
        {
            return () =>
            {
                if (Confirm(txt, title) == DialogResult.No) return;
            };
        }


    }




    public static class CMISUI
    {
        public static OpenFileDialog OpenFDG(params string[] extFilters)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var count = extFilters.Count();
            string filterText = String.Empty;
            foreach (string extFilter in extFilters)
            {
                count--;
                filterText += extFilter + (count != 0 ? "|" : "");
            }

            ofd.Filter = filterText;
            ofd.FilterIndex = 10;
            var dialogResult = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return ofd;
            }
            return null;
        }

        public static void AddGroups(this RibbonPage rp, params RibbonPageGroup[] groups)
        {
            rp.Groups.AddRange(groups);
        }

        public static RibbonPageGroup AddItems(this RibbonPageGroup rpg, params BarItem[] items)
        {
            if (rpg == null) return null;
            rpg.ItemLinks.AddRange(items);
            return rpg;
        }

        public static BarLinkContainerItem AddSubItem(this BarLinkContainerItem barLinkItems, string caption, ItemClickEventHandler itemClick = null, Bitmap icon = null)
        {
            BarButtonItem item = new BarButtonItem();
            item.Caption = caption;
            item.ImageOptions.Image = icon == null ? (Bitmap)CMISRibbonForm.ItemIcon : icon;
            item.ItemClick += itemClick;
            barLinkItems.AddItem(item);
            return barLinkItems;
        }

        // General Tools
        public static BarItem AddCloseItem(this RibbonPage rp, ViewTab view, string itemName = "Close", Bitmap bmp = null, string rpgText= "General")
        {
            if (bmp == null) bmp = (Bitmap)view.OwnerForm.CloseIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                view.OnViewClosing(new CloseEventArgs());
                view.OnViewClose(CloseEventArgs.Empty);
            };
            return item;
        }
        public static BarItem AddRefreshItem(this RibbonPage rp, ViewTab view, string itemName = "Refresh", Bitmap bmp = null, string rpgText = "General")
        {
            if (bmp == null) bmp = (Bitmap)view.OwnerForm.RefreshIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                view.OnViewRefresh(EventArgs.Empty);
            };
            return item;
        }



        //Extntion Method For Badge
        public static Badge AddBadge(this Control control, AdornerUIManager adornerUI)
        {
            Badge badge = new Badge();
            badge.TargetElement = control;
            badge.Appearance.BackColor = Color.DodgerBlue;
            badge.Appearance.ForeColor = Color.White;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge AddBadge(this Control control, AdornerUIManager adornerUI, Color backColor, Color foreColor)
        {
            Badge badge = new Badge();
            badge.TargetElement = control;
            badge.Appearance.BackColor = backColor;
            badge.Appearance.ForeColor = foreColor;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge AddBadge(this RibbonPageGroup rpg, AdornerUIManager adornerUI)
        {
            Badge badge = new Badge();
            badge.TargetElement = rpg;
            badge.Appearance.BackColor = Color.DodgerBlue;
            badge.Appearance.ForeColor = Color.White;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge AddBadge(this RibbonPageGroup rpg, AdornerUIManager adornerUI, Color backColor, Color foreColor)
        {
            Badge badge = new Badge();
            badge.TargetElement = rpg;
            badge.Appearance.BackColor = backColor;
            badge.Appearance.ForeColor = foreColor;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge AddBadge(this BarButtonItem item, AdornerUIManager adornerUI)
        {
            Badge badge = new Badge();
            badge.TargetElement = item;
            badge.Appearance.BackColor = Color.DodgerBlue;
            badge.Appearance.ForeColor = Color.White;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge AddBadge(this BarItem item, AdornerUIManager adornerUI, Color backColor, Color foreColor)
        {
            Badge badge = new Badge();
            badge.TargetElement = item;
            badge.Appearance.BackColor = backColor;
            badge.Appearance.ForeColor = foreColor;
            badge.Properties.TextMargin = new Padding(5, 2, 5, 2);
            adornerUI.Elements.Add(badge);
            return badge;
        }
        public static Badge SetText(this Badge badge,string text)
        {
            badge.Properties.Text = text;
            return badge;
        }
        public static Badge SetLocation(this Badge badge, ContentAlignment contentAlignment)
        {
            badge.Properties.Location = contentAlignment;
            return badge;
        }


        public static BarItem AddItem(this RibbonPage rp,ViewTab view,string caption,string groupCaption,Bitmap bmp)
        {
            var group = rp.Groups.GetGroupByText(groupCaption);
            if (group == null) group = RibbonHandler.NewRPG(groupCaption);
            var item = RibbonHandler.NewItem.ButtonItem(caption, null, bmp);
            group.AddItems(item);
            rp.AddGroups(group);
            return item;
        }


        //Extntion Method For GridTools
        public static BarItem AddToggleSearchGridTool(this RibbonPage rp, ViewTab view, string itemName = "Search", Bitmap bmp = null, string rpgText = "Grid Tools")
        {
            if (bmp == null) bmp = view.GridToolsSearchIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

           

            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                        
                }
                    

                if (grid != null)
                {                                        
                    GridView gv = grid.MainView as GridView;
                    gv.OptionsFind.AlwaysVisible = !gv.OptionsFind.AlwaysVisible;
                    grid.Focus();
                }
                
            };
            return item;
        }
        public static BarItem AddToggleAutoWidthGridTool(this RibbonPage rp, ViewTab view, string itemName = "Auto Width", Bitmap bmp = null, string rpgText = "Grid Tools")
        {
            if (bmp == null) bmp = view.GridToolsAutoWidthIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    GridView gv = grid.MainView as GridView;
                    gv.OptionsView.ColumnAutoWidth = !gv.OptionsView.ColumnAutoWidth;
                    grid.Focus();
                }

            };
            return item;
        }
        public static BarItem AddToggleBestFitGridTool(this RibbonPage rp, ViewTab view, string itemName = "Best Fit", Bitmap bmp = null, string rpgText = "Grid Tools")
        {
            if (bmp == null) bmp = view.GridToolsBestFitIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    GridView gv = grid.MainView as GridView;
                    gv.BestFitColumns();
                    grid.Focus();
                }

            };
            return item;
        }
        public static BarItem AddDateFormatGridTool(this RibbonPage rp, ViewTab view, string itemName = "Grid Date", Bitmap bmp = null, string rpgText = "Grid Tools")
        {
            if (bmp == null) bmp = view.GridToolsDateFormatIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    GridView gv = grid.MainView as GridView;
                    gv.BestFitColumns();
                    grid.Focus();
                }

            };
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
     
        public static BarItem AddResetGridFormatTool(this RibbonPage rp, ViewTab view, string itemName = "Reset", Bitmap bmp = null, string rpgText = "Grid Tools")
        {
            if (bmp == null) bmp = view.GridToolsResetGridFormatIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            return item;
        }
        public static RibbonPage AddGridTools(this RibbonPage rp,ViewTab view)
        {
            rp.AddToggleSearchGridTool(view);
            rp.AddToggleAutoWidthGridTool(view);
            rp.AddToggleBestFitGridTool(view);
            return rp;
        }








        // Add Sign Acion Items
        public static BarItem AddSignPostActionTool(this RibbonPage rp, ViewTab view, string itemName = "Post", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignpostActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignAcceptActionTool(this RibbonPage rp, ViewTab view, string itemName = "Accept", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignAcceptActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignSendBackActionTool(this RibbonPage rp, ViewTab view, string itemName = "SendBack", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignSendBackActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignRejectActionTool(this RibbonPage rp, ViewTab view, string itemName = "Reject", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignRejectActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignUndoActionTool(this RibbonPage rp, ViewTab view, string itemName = "Undo", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignUndoActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignReopenActionTool(this RibbonPage rp, ViewTab view, string itemName = "Reopen", Bitmap bmp = null, string rpgText = "Sign")
        {
            if (bmp == null) bmp = view.SignReopenActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddSignHistoryActionTool(this RibbonPage rp, ViewTab view, string itemName = "History", Bitmap bmp = null, string rpgText = "Sign Tools")
        {
            if (bmp == null) bmp = UIHelperResources.SignHistory;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddAttachmentActionTool(this RibbonPage rp, ViewTab view, string itemName = "Attachment", Bitmap bmp = null, string rpgText = "Sign Tools")
        {
            if (bmp == null) bmp = UIHelperResources.Attachment_Thin_32x32;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);            
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }

        // Add Form Acion Items
        public static BarItem AddNewFormActionTool(this RibbonPage rp, ViewTab view, string itemName = "New", Bitmap bmp = null, string rpgText = "Form")
        {
            if (bmp == null) bmp = view.NewFormActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            return item;
        }
        public static BarItem AddSaveFormActionTool(this RibbonPage rp, ViewTab view, string itemName = "Save", Bitmap bmp = null, string rpgText = "Form")
        {            
            if (bmp == null) bmp = view.SaveFormActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddEditFormActionTool(this RibbonPage rp, ViewTab view, string itemName = "Edit", Bitmap bmp = null, string rpgText = "Form")
        {
            if (bmp == null) bmp = view.EditFormActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddDeleteFormActionTool(this RibbonPage rp, ViewTab view, string itemName = "Delete", Bitmap bmp = null, string rpgText = "Form")
        {
            if (bmp == null) bmp = view.DeleteFormActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }
        public static BarItem AddViewFormActionTool(this RibbonPage rp, ViewTab view, string itemName = "View", Bitmap bmp = null, string rpgText = "Form")
        {
            if (bmp == null) bmp = view.ViewFormActionIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);
            view.MenuItems.Add(item.Caption.ToLower(), item);
            return item;
        }

        //Extntion Method For ExportTools
        public static BarItem AddExcelExportTool(this RibbonPage rp, ViewTab view, string itemName = "Excel", Bitmap bmp = null, string rpgText = "Export Tools")
        {
            if (bmp == null) bmp = view.GridToolsExportToXlsxIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    GridView gv = grid.MainView as GridView;
                    try
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "MS Excel 2007 (*.xlsx)|*.xlsx|MS Excel 2003 (*.xls)|*.xls";
                        sfd.OverwritePrompt = true;
                        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        var dialogResult = sfd.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            string path = sfd.FileName;
                            var format = Path.GetExtension(path);
                            switch (format)
                            {
                                case "xlsx":
                                    gv.ExportToXlsx(path);
                                    break;
                                case "xls":
                                    gv.ExportToXls(path);
                                    break;
                                default:
                                    gv.ExportToXlsx(path);
                                    break;
                            }                            
                        }                      
                    }
                    catch (Exception ex)
                    {
                        ex.ShowMessage();
                    }
                }
            };
            return item;
        }
        public static BarItem AddCsvExportTool(this RibbonPage rp, ViewTab view, string itemName = "CSV", Bitmap bmp = null, string rpgText = "Export Tools")
        {
            if (bmp == null) bmp = view.GridToolsExportToCsvIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    try
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "CSV Format (*.csv)|*.csv";
                        sfd.OverwritePrompt = true;
                        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        var dialogResult = sfd.ShowDialog();

                        GridView gv = grid.MainView as GridView;
                        if (dialogResult == DialogResult.OK)
                        {
                            string path = sfd.FileName;
                            gv.ExportToCsv(path);
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ShowMessage();
                    }
                }

            };
            return item;
        }
        public static BarItem AddPdfExportTool(this RibbonPage rp, ViewTab view, string itemName = "PDF", Bitmap bmp = null, string rpgText = "Export Tools")
        {
            if (bmp == null) bmp = view.GridToolsExportToPdfIcon;
            var item = RibbonHandler.NewItem.ButtonItem(itemName, null, bmp);
            var group = rp.Groups.Any(x => x.Text == rpgText) == false ? RibbonHandler.NewRPG(rpgText) : rp.Groups.FirstOrDefault(x => x.Text == rpgText);
            group.AddItems(item);
            rp.AddGroups(group);

            item.ItemClick += (o, e) =>
            {
                GridControl grid = view.LastFocucedGrid;
                var controls = from c in view.ViewObjects.Values
                               let cc = c.Control as Control
                               where c.Control is Control
                               select cc;
                var focusedControl = controls.FirstOrDefault(x => x.Focused);
                var focucedGrid = focusedControl is GridControl;

                if (focucedGrid)
                {
                    if (grid == null || grid?.Name != focusedControl.Name)
                    {
                        view.LastFocucedGrid = focusedControl as GridControl;
                        grid = view.LastFocucedGrid;
                    }
                }


                if (grid != null)
                {
                    GridView gv = grid.MainView as GridView;
                    try
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "PDF Format (*.pdf)|*.pdf";
                        sfd.OverwritePrompt = true;
                        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        var dialogResult = sfd.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            string path = sfd.FileName;
                            gv.ExportToPdf(path);
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ShowMessage();
                    }
                }

            };
            return item;
        }
        public static RibbonPage AddExportTools(this RibbonPage rp,ViewTab view)
        {
            rp.AddExcelExportTool(view);
            rp.AddCsvExportTool(view);
            rp.AddPdfExportTool(view);
            return rp;
        }




        //Error Handler extention method
        public static void ShowMessage(this Exception ex,string title = "Message")
        {
            if (ex is CMISException) title = $"CMIS {title}";
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static class UIHandler
        {
            public static T ViewInTab<T>(CMISRibbonForm mdiForm,object[] args = null, Image icon = null, RibbonPageCategory rpc = null) where T : ViewTab
            {
                var childForm = (ViewTab)Activator.CreateInstance(typeof(T), args);
                
                childForm.OwnerForm = mdiForm;
                var tabControl = mdiForm.Controls.OfType<TabControl>().First();
                TabPage tabPage = new TabPage();
                tabPage.BackColor = Color.FromArgb(240,240,240);
                tabPage.UseVisualStyleBackColor = false;
                tabControl.TabPages.Add(tabPage);
                var ribbonPage = RibbonHandler.NewRP(childForm.ViewTitle, icon == null ? UIHelperResources.window_16x16 : icon);
                ribbonPage.Text = String.IsNullOrEmpty(childForm.ViewTitle)?childForm.Name: childForm.ViewTitle;
                tabPage.Name = ribbonPage.Name = childForm.ViewIdentity;
                
                mdiForm.OpenTabs.Add(ribbonPage.Name, tabPage);
                if (rpc == null)
                {
                    mdiForm.Ribbon.DefaultPageCategory.Pages.Add(ribbonPage);
                }
                else
                {
                    var selectedRPC = mdiForm.Ribbon.PageCategories.GetCategoryByText(rpc.Text);
                    if (selectedRPC == null)
                        throw new Exception("CMIS ERROR,RibbonPageCategory not founded!");

                    selectedRPC.Pages.Add(ribbonPage);
                }

                childForm.TabControl = tabControl;
                childForm.TabPage = tabPage;
                childForm.RibbonPage = ribbonPage;
                                              
                mdiForm.Ribbon.SelectPage(ribbonPage);
                tabControl.SelectedTab = tabPage;

                


                RibbonPageEventArgs rpea = new RibbonPageEventArgs();
                rpea.RibbonControl = mdiForm.Ribbon;
                rpea.View = childForm;
                rpea.RibbonPageCategory = rpc == null ? mdiForm.Ribbon.DefaultPageCategory : rpc;
                rpea.RibbonPage = ribbonPage;

                if (mdiForm.ShowHomeMenuItems && mdiForm.HomePage == ribbonPage.Text && mdiForm.CloseItemLocation == CloseItemAlignment.End)
                    RibbonHandler.GenerateHomeMenus(childForm);

                childForm.OnRibbonPageAdded(rpea);

                if (mdiForm.ShowHomeMenuItems && mdiForm.HomePage == ribbonPage.Text && mdiForm.CloseItemLocation == CloseItemAlignment.Start)
                    RibbonHandler.GenerateHomeMenus(childForm);

                tabPage.Controls.Add(childForm);
                childForm.Dock = System.Windows.Forms.DockStyle.Fill;


                if (mdiForm.ShowHomeMenuItems && mdiForm.HomePage == ribbonPage.Text && mdiForm.CloseItemLocation == CloseItemAlignment.Start)
                    RibbonHandler.GenerateHomeMenus(childForm);

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1;
                int counter = 0;
                timer.Tick +=(o, ev) =>
                {
                    counter++;
                    if (counter >= 10)
                    {
                        timer.Stop();
                        childForm.OnBeforeViewLoad(EventArgs.Empty);
                        childForm.OnViewLoaded(EventArgs.Empty);
                    }
                };
                timer.Start();


              

                return (T)childForm;
            }

            internal static ViewTab ViewInTab(Type type, CMISRibbonForm mdiForm, Image icon = null, RibbonPageCategory rpc = null)
            {
                var childForm = (ViewTab)Activator.CreateInstance(type);
                childForm.OwnerForm = mdiForm;
                var tabControl = mdiForm.Controls.OfType<TabControl>().First();
                TabPage tabPage = new TabPage();
                tabPage.BackColor = Color.FromArgb(240,240,240);
                tabPage.UseVisualStyleBackColor = false;
                tabControl.TabPages.Add(tabPage);
                var ribbonPage = RibbonHandler.NewRP(String.IsNullOrEmpty(childForm.ViewTitle) ? childForm.Name : childForm.ViewTitle, icon == null ? UIHelperResources.window_16x16 : icon );
                ribbonPage.Name = tabPage.Name = childForm.ViewIdentity;

                mdiForm.OpenTabs.Add(ribbonPage.Name, tabPage);
                if (rpc == null)
                    mdiForm.Ribbon.DefaultPageCategory.Pages.Add(ribbonPage);
                else
                    rpc.Pages.Add(ribbonPage);

                childForm.TabControl = tabControl;
                childForm.TabPage = tabPage;

                mdiForm.Ribbon.SelectedPage = ribbonPage;
                tabControl.SelectedTab = tabPage;
                childForm.RibbonPage = ribbonPage;

                RibbonPageEventArgs rpea = new RibbonPageEventArgs();
                rpea.RibbonControl = mdiForm.Ribbon;
                rpea.View = childForm;
                rpea.RibbonPageCategory = rpc == null ? mdiForm.Ribbon.DefaultPageCategory : rpc;
                rpea.RibbonPage = ribbonPage;

                childForm.OnRibbonPageAdded(rpea);


                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1;
                int counter = 0;
                timer.Tick += (o, ev) =>
                {
                    counter++;
                    if (counter >= 20)
                    {
                        timer.Stop();
                        childForm.OnBeforeViewLoad(EventArgs.Empty);
                        childForm.OnViewLoaded(EventArgs.Empty);
                    }
                };
                timer.Start();

                tabPage.Controls.Add(childForm);
                childForm.Dock = System.Windows.Forms.DockStyle.Fill;

                return childForm;
            }           

            private static T ViewInForm<T>(ViewTab view,object[] args = null) where T : ViewForm
            {
                XtraForm frm = new XtraForm();
                frm.DialogResult = DialogResult.Cancel;
                ViewForm childForm = (ViewForm)Activator.CreateInstance(typeof(T),args);
                frm.Width = childForm.Width;
                frm.Height = childForm.Height + 28;
                frm.Controls.Add(childForm);
                frm.Text = childForm.ViewTitle;
                frm.Icon = view.OwnerForm.Icon;
                childForm.OwnerForm = frm;
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Load += (o, e) =>
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1;
                    int counter = 0;
                    timer.Tick += (obj, ev) =>
                    {
                        counter++;
                        if (counter >= 5)
                        {
                            timer.Stop();
                            childForm.OnBeforeViewLoad(e);
                            childForm.OnViewLoaded(e);
                        }
                    };
                    timer.Start();
                    
                };

                childForm.Dock = DockStyle.Fill;
                return (T)childForm;
            }

            public static T ViewInNormalForm<T>(ViewTab view,object[] args = null) where T : ViewForm
            {
                var viewForm = ViewInForm<T>(view,args);
                viewForm.OwnerForm.Show();
                return viewForm;
            }

            public static T ViewInDialogForm<T>(ViewTab view ,object[] args = null) where T : ViewForm
            {
                var viewForm = ViewInForm<T>(view,args);
                viewForm.OwnerForm.ShowDialog();
                return viewForm;
            }

            public static T ViewInNoControlBoxDialogForm<T>(ViewTab view,object[] args = null) where T : ViewForm
            {
                var viewForm = ViewInForm<T>(view,args);
                viewForm.OwnerForm.MaximizeBox = false;
                viewForm.OwnerForm.MinimizeBox = false;
                viewForm.OwnerForm.ShowDialog();
                return viewForm;
            }

            public static T ViewInNoControlBoxNoSizableDialogForm<T>(ViewTab view,object[] args = null) where T : ViewForm
            {
                var viewForm = ViewInForm<T>(view,args);
                viewForm.OwnerForm.FormBorderStyle = FormBorderStyle.Fixed3D;
                viewForm.OwnerForm.MaximizeBox = false;
                viewForm.OwnerForm.MinimizeBox = false;
                viewForm.OwnerForm.ShowDialog();
                return viewForm;
            }
        }

        public static class RibbonHandler
        {
            #region Ribbon Helper

            public static RibbonPageCategory NewRPC(RibbonControl rc, string ribbonPageCategoryText, RPCColor color = RPCColor.Blue, params RibbonPage[] ribbonPages)
            {
                var existRpc = rc.PageCategories.OfType<RibbonPageCategory>().FirstOrDefault(x => x.Text == ribbonPageCategoryText);
                if (existRpc != null)
                    return existRpc;

                var rpcColor = Color.DodgerBlue;
                switch (color)
                {
                    case RPCColor.Blue:
                        rpcColor = Color.DodgerBlue;
                        break;
                    case RPCColor.Orang:
                        rpcColor = Color.Orange;
                        break;
                    case RPCColor.Pink:
                        rpcColor = Color.Pink;
                        break;
                    case RPCColor.Green:
                        rpcColor = Color.Green;
                        break;
                    case RPCColor.Red:
                        rpcColor = Color.Red;
                        break;
                    case RPCColor.LightBlue:
                        rpcColor = Color.LightBlue;
                        break;
                    case RPCColor.LightOrang:
                        rpcColor = Color.Orchid;
                        break;
                    case RPCColor.LightPink:
                        rpcColor = Color.LightPink;
                        break;
                    case RPCColor.LightGreen:
                        rpcColor = Color.LightGreen;
                        break;
                    case RPCColor.LightRed:
                        rpcColor = Color.OrangeRed;
                        break;
                    default:
                        rpcColor = Color.DodgerBlue;
                        break;
                }

                RibbonPageCategory rpc = new RibbonPageCategory(ribbonPageCategoryText, rpcColor);
                rpc.Pages.AddRange(ribbonPages);
                rc.PageCategories.Add(rpc);
                return rpc;
            }

            public static RibbonPage NewRP(string caption, params RibbonPageGroup[] rpgs)
            {
                RibbonPage rp = new RibbonPage(caption);
                rp.Name = Guid.NewGuid().ToString("N").Substring(0, 10);
                rp.ImageOptions.ImageToTextIndent = 8;
                rp.Groups.AddRange(rpgs);
                return rp;
            }

            public static RibbonPage NewRP(string caption, Image icon = null, params RibbonPageGroup[] rpgs)
            {
                RibbonPage rp = new RibbonPage(caption);
                rp.Name = Guid.NewGuid().ToString("N").Substring(0, 10);
                rp.ImageOptions.Image = icon;
                rp.ImageOptions.ImageToTextIndent = 8;
                rp.Groups.AddRange(rpgs);
                return rp;
            }

            public static RibbonPageGroup NewRPG(string caption, string permisionName = null)
            {
                RibbonPageGroup rpg = new RibbonPageGroup(caption);
                rpg.Name = Guid.NewGuid().ToString("N").Substring(0, 10);
                rpg.AllowTextClipping = false;
                rpg.Tag = permisionName;
                return rpg;
            }


            public static RibbonPageGroup NewRPG(string caption)
            {
                RibbonPageGroup rpg = new RibbonPageGroup(caption);
                rpg.Name = Guid.NewGuid().ToString("N").Substring(0, 10);
                rpg.AllowTextClipping = false;
                return rpg;
            }


            public static RibbonPageGroup NewRPG(string caption,string permisionName = null, params BarItem[] items)
            {
                RibbonPageGroup rpg = new RibbonPageGroup(caption);
                rpg.Name = Guid.NewGuid().ToString("N").Substring(0, 10);
                rpg.AllowTextClipping = false;
                rpg.ItemLinks.AddRange(items);
                rpg.Tag = permisionName;
                return rpg;
            }

            public static RibbonPageCollection AddRpToRpc(RibbonPageCategory rpc, params RibbonPage[] ribbonPages)
            {
                rpc.Pages.AddRange(ribbonPages);
                return rpc.Pages;
            }

            public static RibbonPageGroupCollection AddRpgToRp(RibbonPage rp, params RibbonPageGroup[] ribbonPageGroups)
            {
                try
                {
                    rp.Groups.AddRange(ribbonPageGroups);
                    return rp.Groups;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }

            public static RibbonPageGroupItemLinkCollection AddItemToRpg(RibbonPageGroup rpg, params BarItem[] barItems)
            {
                rpg.ItemLinks.AddRange(barItems);
                return rpg.ItemLinks;
            }

            public static class NewItem
            {
                public static BarButtonItem ButtonItem(string caption, string permissionName,ItemClickEventHandler itemClick = null, Bitmap icon = null, RibbonItemStyles itemStyles = RibbonItemStyles.Large)
                {
                    BarButtonItem item = new BarButtonItem();
                    item.RibbonStyle = itemStyles;
                    item.Caption = caption;
                    item.AccessibleName = permissionName;
                    item.ImageOptions.LargeImage = icon==null? (Bitmap)CMISRibbonForm.ItemIcon:icon;
                    item.ItemClick += itemClick;
                    return item;
                }
                public static BarItem ButtonItem(string caption, ItemClickEventHandler itemClick = null, Bitmap icon = null, RibbonItemStyles itemStyles = RibbonItemStyles.Large)
                {
                    BarButtonItem item = new BarButtonItem();
                    item.RibbonStyle = itemStyles;
                    item.Caption = caption;
                    item.ImageOptions.LargeImage = icon == null ? (Bitmap)CMISRibbonForm.ItemIcon : icon;
                    item.ItemClick += itemClick;
                    return item;
                }

                public static BarLinkContainerItem DropDownItem(string caption, string permissionName, Bitmap icon = null, RibbonItemStyles itemStyles = RibbonItemStyles.Large)
                {
                    BarLinkContainerItem item = new BarLinkContainerItem();
                    item.RibbonStyle = itemStyles;                      
                    item.Caption = caption;
                    item.AccessibleName = permissionName;
                    item.ImageOptions.LargeImage = icon == null ? (Bitmap)CMISRibbonForm.ItemIcon : icon;
                    return item;
                }
               
            }

            #endregion


            public static List<GroupedAndSortedMenuListModel> GetMenuList(string appSchema)
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                var menuList = from a in assemblies
                               from t in a.GetTypes()
                               from rmi in t.GetCustomAttributes(typeof(RibbonMenuItem), false)
                               from rmg in t.GetCustomAttributes(typeof(RibbonMenuGroup), false)
                               from rii in t.GetCustomAttributes(typeof(RibbonItemIcon), false)
                               from sc in t.GetCustomAttributes(typeof(AppSchema), false)
                               let menuItem = (rmi as RibbonMenuItem)
                               let menuGroup = (rmg as RibbonMenuGroup)
                               let menuIcon = (rii as RibbonItemIcon)
                               let schema = (sc as AppSchema)

                               where t.IsClass == true && schema.Schemas.Any(x => x == appSchema)

                               let list = new MenuListModel { Form = t, Title = menuItem.Title, GroupTitle = menuGroup.Title, ItemOrderId = menuItem.OrderId, GroupOrderId = menuGroup.OrderId, ResourceName = menuIcon.ResourceName, ResourceKey = menuIcon.ResourceKey }

                               orderby list.GroupOrderId
                               select list;

                List<GroupedAndSortedMenuListModel> listMenu = new List<GroupedAndSortedMenuListModel>();
                foreach (var item in menuList)
                {
                    var group = listMenu.FirstOrDefault(x => x.RibbonPageGroup == item.GroupTitle);
                    if (group != null)
                    {
                        group.Menus.Add(item);
                    }
                    else
                    {
                        listMenu.Add(
                            new GroupedAndSortedMenuListModel
                            {
                                RibbonPageGroup = item.GroupTitle,
                                Menus = new List<MenuListModel> { item }
                            }
                        );
                    }
                }

                return listMenu;
            }

            private static object GetResource(string resourceName, string key)
            {
                try
                {
                    var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                    var resource = from a in assemblies
                                   from t in a.GetManifestResourceNames()
                                   where t.ToLower().Contains(resourceName.ToLower())
                                   select new { Asm = a, ResName = t.Replace(".resources", "") };
                    ResourceManager RM = new ResourceManager(resource.First().ResName,
                        resource.First().Asm); 
                    var obj = RM.GetObject(key);
                    return obj;
                }
                catch (Exception)
                {
                    return null;
                }

            }

            public static void GenerateHomeMenus(ViewTab childForm,RibbonPageCategory rpc = null,Image homeRibbonPageIcon = null)
            {
                var menus = GetMenuList(childForm.OwnerForm.Schema);
                var r = childForm.OwnerForm.Ribbon;
                if (menus.Any())
                {
                    var category = rpc == null ? r.DefaultPageCategory : rpc;
                    var rpHome = category.Pages.FirstOrDefault(p => p.Text == childForm.OwnerForm.HomePage);
                    if (rpHome != null)
                    {
                        RibbonPageGroup rpg = null;
                        foreach (GroupedAndSortedMenuListModel menu in menus)
                        {
                            var sortedListMenu = from m in menu.Menus
                                                 orderby m.ItemOrderId
                                                 select m;
                            foreach (var itemMenu in sortedListMenu)
                            {
                                rpg = rpHome.Groups.FirstOrDefault(g => g.Text == itemMenu.GroupTitle);

                                if (rpg == null)
                                    rpg = NewRPG(itemMenu.GroupTitle);

                                var icon = GetResource(itemMenu.ResourceName, itemMenu.ResourceKey) as Bitmap;

                                var item = NewItem.ButtonItem(itemMenu.Title, (o, s) =>
                                {
                                    UIHandler.ViewInTab(itemMenu.Form, childForm.OwnerForm, homeRibbonPageIcon, category);

                                }, icon);

                                AddItemToRpg(rpg,item);
                                AddRpgToRp(rpHome,rpg);
                            }
                        }
                    }
                }
            }
        }

    }
}
