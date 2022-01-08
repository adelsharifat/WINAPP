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
                    gv.SetRowCellValue(rowHandle, "REJ", 0);
                    gv.SetRowCellValue(rowHandle, "NA", 0);
                    break;
                case "REJ":
                    gv.SetRowCellValue(rowHandle, "ACC", 0);
                    gv.SetRowCellValue(rowHandle, "NA", 0);
                    break;
                case "NA":
                    gv.SetRowCellValue(rowHandle, "ACC", 0);
                    gv.SetRowCellValue(rowHandle, "REJ", 0);
                    break;
            }
        }

    }
}
