using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement.Infrastructure.Model
{
    public class AclModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public bool? Allow { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public string Description { get; set; }
        public int? ProjectId { get; set; }
        public DataTable AclItems { get; set; }
    }
}
