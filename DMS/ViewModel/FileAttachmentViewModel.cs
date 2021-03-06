using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.ViewModel
{
    public class FileAttachmentViewModel
    {
        public string File { get; set; }
        public int Id { get; set; }
        public Guid stream_id { get; set; }
        public byte[] FileStream { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public string CustomType { get; set; }
        public string Remark { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FilePath { get; set; }
        public string FileTableName { get; set; }
    }
}
