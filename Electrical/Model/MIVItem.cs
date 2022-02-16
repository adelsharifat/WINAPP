using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.Model
{
    public class MIVItem
    {
        public int Id { get; set; }
        public string KeyDictionary { get=>$"{InventoryBalanceId}"; }
        public int InventoryBalanceId { get; set; }
        public int ItemCodeId { get; set; }
        public int? UnitId { get; set; }
        public int? CompanyId { get; set; }
        public string ItemCode { get; set; }
        public string Unit { get; set; }
        public string  Company { get; set; }
        public decimal Balance { get; set; }
        public decimal Qty { get; set; }
        public string Remark { get; set; }
        public string CreatedUser { get; set; } = LoginInfo.FullName;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
