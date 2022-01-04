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
        public int ResultId { get; set; }
        public int RowNo { get; set; }
        public string ItemName { get; set; }
        public int InspectionResult { get; set; }
    }
}
