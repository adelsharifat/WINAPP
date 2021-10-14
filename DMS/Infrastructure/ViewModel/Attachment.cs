using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIEngin.Infrastructure.ViewModel
{
    public class Attachment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string ObjectName { get; set; }
        public IList<DbFileAttachment> Files { get; set; }
    }
}
