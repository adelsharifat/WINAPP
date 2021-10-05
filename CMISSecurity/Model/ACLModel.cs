using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISSecurity.Model
{
    public class ACLModel
    {
        public int Id { get; set; }
        public string Schema { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Allow { get; set; }
        public DataTable ItemsDataProvider { get; set; }
    }
}
