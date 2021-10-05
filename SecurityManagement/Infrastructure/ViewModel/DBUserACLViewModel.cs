using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement.Infrastructure.ViewModel
{
    public class DBUserACLViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Allow { get; set; }
        public int? AclItemId { get; set; }
        public int? Value { get; set; }
    }
}
