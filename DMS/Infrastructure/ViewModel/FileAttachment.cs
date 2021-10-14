using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISUIEngin.Infrastructure.ViewModel
{
    public class FileAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string CustomType { get; set; }
        public string Remark { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FilePath { get; set; }
        public string FileTableName { get; set; }
    }
}
