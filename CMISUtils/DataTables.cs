using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUtils
{
    public static class DataTables
    {
        public static void Init3ColumnItemAnsResult(GridView gv, string columnFieldName, int rowHandle)
        {
            switch (columnFieldName)
            {
                case "ACC":
                    var accValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "ACC"));
                    gv.SetRowCellValue(rowHandle, "ACC", !accValue);
                    gv.SetRowCellValue(rowHandle, "REJ", 0);
                    gv.SetRowCellValue(rowHandle, "NA", 0);
                    accValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "ACC"));
                    gv.SetRowCellValue(rowHandle, "ItemValue", accValue==true?1:(int?)null);
                    break;
                case "REJ":
                    var rejValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "REJ"));
                    gv.SetRowCellValue(rowHandle, "ACC", 0);
                    gv.SetRowCellValue(rowHandle, "REJ", !rejValue);
                    gv.SetRowCellValue(rowHandle, "NA", 0);
                    rejValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "REJ"));
                    gv.SetRowCellValue(rowHandle, "ItemValue", rejValue == true ? -1 : (int?)null);
                    break;
                case "NA":
                    var naValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "NA"));
                    gv.SetRowCellValue(rowHandle, "ACC", 0);
                    gv.SetRowCellValue(rowHandle, "REJ", 0);
                    gv.SetRowCellValue(rowHandle, "NA", !naValue);
                    naValue = Convert.ToBoolean(gv.GetRowCellValue(rowHandle, "NA"));
                    gv.SetRowCellValue(rowHandle, "ItemValue", naValue == true ? 0 : (int?)null);
                    break;
            }
        }

    }
}
