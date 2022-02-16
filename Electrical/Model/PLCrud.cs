using DMS.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.Model
{
    public class SavePLDocument
    {
        public int? DocumentId { get; set; }
        public int ProjectId { get; set; }
        public int CompanyId { get; set; } //Warehouse CompanyId
        public int UserId { get; set; }
        public int UnitId { get; set; }
        public DataTable PackingItems { get; set; }
    }

    public class SignPLDocument
    {
        public SignType SignType { get; set; } = SignType.Post;
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public int ObjectId { get; set; }
        public string NextRole { get; set; }
        public string MachineName { get; set; }
        public string ActiveDirectoryName { get; set; }
        public int? CompanyId { get; set; }
    }
}
