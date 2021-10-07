﻿using CMISUtils.Infrastructure.ViewModel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUtils
{
    public static class Utilities
    {
        //Misc
        //public static void Call(object callByAttribute, string name)
        //{
        //    Call(callByAttribute, name, null);
        //}

        //public static void Call(object callByAttribute, string name, object[] args)
        //{
        //    PropertyInfo prop = callByAttribute.GetType().GetProperties()
        //        .Where(p => p.IsDefined(typeof(CodeNameAttribute), false))
        //         .SingleOrDefault(p => ((CodeNameAttribute)(p.GetCustomAttributes(typeof(CodeNameAttribute), false)).First()).NameList.Contains(name));
        //    if (prop != null)
        //        callByAttribute.GetType().InvokeMember(prop.Name, BindingFlags.GetProperty, null, callByAttribute, null);

        //    MethodInfo method = callByAttribute.GetType().GetMethods()
        //        .Where(p => p.IsDefined(typeof(CodeNameAttribute), false))
        //         .SingleOrDefault(p => ((CodeNameAttribute)(p.GetCustomAttributes(typeof(CodeNameAttribute), false)).First()).NameList.Contains(name));
        //    if (method != null)
        //        callByAttribute.GetType().InvokeMember(method.Name, BindingFlags.InvokeMethod, null, callByAttribute, args);
        //    return;
        //}


        //Server
        public static DateTime ServerDateTime(bool dateWithTime = false)
        {
            try
            {
                return CMISDAL.Common.CommonDals.Server.ServerDateTime();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        // Convert datarow to another type
        public static T? To<T>(this DataRow dr, string columnName) where T : struct
        {
            var val = dr[columnName] == DBNull.Value ? null : ((T?)Convert.ChangeType(dr[columnName], typeof(T)));
            return val;
        }

        public static string ToString(this DataRow dr, string columnName)
            => dr[columnName].ToString();

        public static int ToInt(this DataRow dr, string columnName)
            => Convert.ToInt32(dr[columnName]);

        public static bool ToBoolean(this DataRow dr, string columnName)
          => Convert.ToBoolean(dr[columnName]);

        public static byte[] ToByteArray(this DataRow dr, string columnName)
            => (byte[])dr[columnName];

        public static DateTime ToDateTime(this DataRow dr, string columnName)
            => Convert.ToDateTime(dr[columnName]);

        public static Image ToImage(this byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static Bitmap ResizeImage(this Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        //Combo
        public static void Fill(this LookUpEdit lookUpEdit, DataTable dataTable, string displayMember = "Name", string valueMember = "Id")
        {
            try
            {
                lookUpEdit.Properties.DataSource = dataTable;
                lookUpEdit.Properties.DisplayMember = displayMember;
                lookUpEdit.Properties.ValueMember = valueMember;
                lookUpEdit.Properties.KeyMember = valueMember;
                lookUpEdit.ItemIndex = 0;
            }
            catch (Exception)
            {
                return;
            }
        }

        //Grid
        public static DataTable GetDataTable(this GridView view)
        {
            DataTable dt = new DataTable();
            foreach (GridColumn c in view.Columns)
                dt.Columns.Add(c.FieldName, c.ColumnType);

            for (int r = 0; r < view.DataRowCount; r++)
            {
                object[] rowValues = new object[dt.Columns.Count];
                for (int c = 0; c < dt.Columns.Count; c++)
                    rowValues[c] = view.GetRowCellValue(r, dt.Columns[c].ColumnName);
                dt.Rows.Add(rowValues);
            }
            return dt;
        }

        public static bool SelectionInvalid(this GridControl gc)
        {
            if ((gc.MainView as GridView).FocusedRowHandle < 0 || (gc.MainView as GridView).RowCount <= 0)
                return true;
            return false;
        }

        public static bool SelectionInvalid(this GridView gv)
        {
            if (gv.FocusedRowHandle < 0 || gv.RowCount <= 0)
                return true;
            return false;
        }

        public static GridControl AutoWidth(this GridControl gc, bool enable = true)
        {
            (gc.MainView as GridView).OptionsView.ColumnAutoWidth = enable;
            return gc;
        }

        public static GridView AutoWidth(this GridView gv, bool enable = true)
        {
            gv.OptionsView.ColumnAutoWidth = enable;
            return gv;
        }

        public static GridControl BestFit(this GridControl gc)
        {
            (gc.MainView as GridView).OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            (gc.MainView as GridView).BestFitColumns();
            return gc;
        }

        public static GridView BestFit(this GridView gv)
        {
            gv.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gv.BestFitColumns();
            return gv;
        }

        public static GridView TextCenter(this GridView gv,string columns,char delimiter = ',')
        {
            try
            {
                var columnNames = columns.Split(delimiter);

                foreach (GridColumn column in gv.Columns)
                {
                    if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gv.Columns[column.FieldName].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                        gv.Columns[column.FieldName].AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;
                    }
                }
                return gv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static GridView TextUnderline(this GridView gv, string columns, char delimiter = ',')
        {
            try
            {
                var columnNames = columns.Split(delimiter);

                foreach (GridColumn column in gv.Columns)
                {
                    if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gv.Columns[column.FieldName].AppearanceCell.FontStyleDelta = FontStyle.Underline;
                    }
                }
                return gv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static GridView TextBold(this GridView gv, string columns, char delimiter = ',')
        {
            try
            {
                var columnNames = columns.Split(delimiter);

                foreach (GridColumn column in gv.Columns)
                {
                    if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gv.Columns[column.FieldName].AppearanceCell.FontStyleDelta = FontStyle.Bold;
                    }
                }
                return gv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static GridView TextColor(this GridView gv, string columns,Color color, char delimiter = ',')
        {
            try
            {
                var columnNames = columns.Split(delimiter);
                if (color == null) color = Color.Transparent;
                foreach (GridColumn column in gv.Columns)
                {
                    if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gv.Columns[column.FieldName].AppearanceCell.ForeColor = color;
                    }
                }
                return gv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static GridView TextBackColor(this GridView gv, string columns,Color color, char delimiter = ',')
        {
            try
            {
                var columnNames = columns.Split(delimiter);
                if (color == null) color = Color.Transparent;
                foreach (GridColumn column in gv.Columns)
                {
                    if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gv.Columns[column.FieldName].AppearanceCell.BackColor = color;
                    }
                }
                return gv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public static void HandCursor(this GridView gv, MouseEventArgs e, string columnName)
        {
            GridHitInfo hi = gv.CalcHitInfo(e.X, e.Y);
            if (hi.Column == gv.Columns[columnName])
                gv.GridControl.Cursor = Cursors.Hand;
            else
                gv.GridControl.Cursor = Cursors.Default;
        }

        public static GridControl HideColumns(this GridControl gc, string columns, char delimiter = ',')
        {
            var gView = gc.MainView as GridView;
            var columnNames = columns.Split(delimiter);

            foreach (GridColumn column in gView.Columns)
            {
                if (columnNames.FirstOrDefault(x => x == column.FieldName) != null)
                {
                    gView.Columns[column.FieldName].Visible = false;
                }
            }
            return gc;
        }

        public static void EditableColumns(this GridControl grid, params string[] columns)
        {
            try
            {
                var gView = grid.MainView as GridView;
                gView.OptionsBehavior.Editable = true;
                foreach (GridColumn column in gView.Columns)
                {
                    if (columns.FirstOrDefault(x => x == column.FieldName) != null)
                    {
                        gView.Columns[column.FieldName].OptionsColumn.AllowEdit = true;
                    }
                    else
                    {
                        gView.Columns[column.FieldName].OptionsColumn.AllowEdit = false;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public static List<GridColumn> GetColumnsByTypeFormat(GridControl gc, FormatType ft)
        {
            List<GridColumn> columnList = new List<GridColumn>();
            try
            {
                var view = (GridView)gc.MainView;
                foreach (GridColumn column in view.Columns)
                {
                    if (column.ColumnType.Name.ToString() == SqlDbType.DateTime.ToString())
                        columnList.Add(column);
                }
                return columnList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static object CellValue(this GridView gridView, string columnName)
            => gridView.GetFocusedDataRow()[columnName];

        public static object CellValue(this GridControl gridControl, string columnName)
            => (gridControl.MainView as GridView).GetFocusedDataRow()[columnName];

        public static List<IdsViewModel> SelectedIds(GridView gv, string column)
        {
            var id = Convert.ToInt32(gv.GetFocusedRowCellValue(column));
            var ids = gv.GetSelectedRows();
            List<IdsViewModel> Ids = new List<IdsViewModel>();

            if (!ids.Any() && id > 0)
                Ids.Add(new IdsViewModel { Id = id });

            foreach (var item in ids)
            {
                Ids.Add(new IdsViewModel { Id = Convert.ToInt32(gv.GetRowCellValue(item, column)) });
            }
            return Ids;
        }







        //TileControl
        public static void DisableBackColor(this TileControl tileControl,Color backColor)
        {
            if (backColor == null)
                backColor = Color.LightSlateGray;
            foreach (TileGroup tileGroup in tileControl.Groups)
            {
                foreach (TileItem tile in tileGroup.Items)
                {
                    if (!tile.Enabled)
                        tile.AppearanceItem.Normal.BackColor = backColor;
                }
            }
        }

        public static void DisableModeBackColor(this TileControl tileControl)
        {
            foreach (TileGroup tileGroup in tileControl.Groups)
            {
                foreach (TileItem tile in tileGroup.Items)
                {
                    if (!tile.Enabled)
                        tile.AppearanceItem.Normal.BackColor = Color.LightSlateGray;
                }
            }
        }







        //DataTable
        public static DataTable ChangeTo<T>(this DataColumn column, Func<object, T> conversion)
        {
            var dc = new DataColumn();
            dc.ColumnName = column.ColumnName;
            column.ColumnName += "_Old";
            dc.DataType = typeof(T);
            column.Table.Columns.Add(dc);

            foreach (DataRow row in column.Table.Rows)
            {
                row[dc] = conversion(row[column]);
            }


            column.Table.Columns.Remove(column);

            return dc.Table;
        }
        public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = ToEntity<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T ToEntity<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }


    }

    public static class SecurityHelper
    {
        public static string ActiveDirecotryName
        {
            get { return GetActiveDirectoryName(); }
        }

        public static string MachineName
        {
            get { return GetMachineName(); }
        }

        public static string MachineIp
        {
            get { return GetIpAddress(); }
        }

        private static string GetActiveDirectoryName()
        {
            try
            {
                return WindowsIdentity.GetCurrent()?.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string GetMachineName()
        {
            try
            {
                return Environment.MachineName;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private static string GetIpAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                string address = String.Empty;
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        address = ip.ToString();
                    }
                }
                return address;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }


    //public static class ReportHelper
    //{
    //    public static StiReport Init(byte[] reportFile)
    //    {
    //        var report = new Stimulsoft.Report.StiReport();
    //        report.Load(reportFile);
    //        var conStrings = ConnectionST.GetConnectionString();
    //        report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", conStrings));

    //        report.Dictionary.Synchronize();

    //        //Update genric variables
    //        report.Dictionary.Variables["CMISUser"].Value = LoginInfo.FullName;
    //        report.Dictionary.Variables["ActiveDirectoryUser"].Value = SecurityHelper.ActiveDirecotryName;
    //        report.Dictionary.Variables["MachineName"].Value = SecurityHelper.MachineName;
    //        report.Dictionary.Variables["ServerDateTime"].Value = Utilities.ServerDateTime(true).ToString();
    //        report.Dictionary.Variables["ServerPersianDateTime"].Value = AmirCalendar.FarsiDateHelper.GetShortFarsiDate(Utilities.ServerDateTime(true));

    //        StiPage stiPage = report.Pages[0];
    //        StiText cmisWaterMark = new StiText(new RectangleD(0, 0, 0.2, 1.2));
    //        cmisWaterMark.Text = "Created by CMIS";
    //        cmisWaterMark.HorAlignment = StiTextHorAlignment.Center;
    //        cmisWaterMark.VertAlignment = StiVertAlignment.Center;
    //        cmisWaterMark.Name = "cmisWaterMark";
    //        cmisWaterMark.Top = 0.25;
    //        cmisWaterMark.Left = 0;
    //        cmisWaterMark.Brush = new StiSolidBrush(System.Drawing.Color.FromArgb(34, 34, 38));
    //        cmisWaterMark.TextBrush = new StiSolidBrush(System.Drawing.Color.White);
    //        cmisWaterMark.TextOptions.Angle = 90;
    //        stiPage.Components.Add(cmisWaterMark);

    //        return report;
    //    }
    //    public static StiReport AddSqlParameter(this StiReport sr, string stimulDataSourceName, string parameterName, string value)
    //    {
    //        sr.Dictionary.DataSources[stimulDataSourceName].Parameters[parameterName].Value = value;
    //        return sr;
    //    }
    //    public static StiReport Show(this StiReport sr, bool showAsDialog)
    //    {
    //        sr.Compile();
    //        sr.Show(true);
    //        return sr;
    //    }



    //}

}