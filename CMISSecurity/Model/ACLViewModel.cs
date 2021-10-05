using CMISSecurity.Infrastructure.Enum;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISSecurity.Model
{
    public class ACLViewModel
    {
        public int Id { get; set; }
        public string Schema { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AclCheckState Allow { get; set; }
        public string Value { get; set; }
        public CheckedListBoxItem[] ItemsDataProvider { get; set; }
        public RepositoryItemCheckedComboBoxEdit Repository { get; set; }
    }
}
