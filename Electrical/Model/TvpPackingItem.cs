using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.Model
{
    public class TvpPackingItem
    {
        public int Id { get; set; }        
        public int ItemCodeId { get; set; }
        public string ItemCode { get; set; }
        public int UnitId { get; set; }
        public int VendorId { get; set; }
        public string TagNo { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string PackingNo { get; set; }
        public decimal PLQty { get; set; }
        public int QtyUnitId { get; set; }
    }
}
