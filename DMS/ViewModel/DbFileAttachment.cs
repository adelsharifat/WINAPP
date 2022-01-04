using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.ViewModel
{
    public class DbFileAttachment
    {
        public int Id { get; set; }
        public string stream_id { get; set; }
        public byte[] FileStream { get; set; }
        public string FileName { get; set; }
        public string Remark { get; set; }
        public string Type { get; set; }
        public string CustomType { get; set; }
    }
}
