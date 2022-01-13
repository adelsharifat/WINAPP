using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical.Model
{
    public class CFItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int RowNo { get; set; }
        public string Name { get; set; }
        public bool? ACC { get; set; }
        public bool? REJ { get; set; }
        public bool? NA { get; set; }
        public int? ItemValue { get; set; }
    }
}
