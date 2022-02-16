using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.Model
{
    public class TvpMIV
    {
        public int Id { get; set; }
        public int InventoryBalnceId { get; set; }
        public int ItemCodeId { get; set; }
        public int? WarehouseCompanyId { get; set; }
        public int? UnitId { get; set; }
        public decimal Qty { get; set; }
        public string Remark { get; set; }
    }
}
