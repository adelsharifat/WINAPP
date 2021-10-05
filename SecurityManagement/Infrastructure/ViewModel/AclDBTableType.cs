using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement.Infrastructure.ViewModel
{
    public class AclDBTableType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Allow { get; set; }
        public string Value { get; set; }
    }
}
