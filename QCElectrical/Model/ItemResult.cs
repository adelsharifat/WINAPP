using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical.Model
{
    public class ItemResult
    {
        public int? Id { get; set; }
        public int ItemId { get; set; }
        public int RoleOrder { get; set; }
        public int? ItemValue { get; set; }
    }
}
