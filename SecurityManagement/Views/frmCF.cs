using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUIHelper.UserControls;
using CMISUtils;
using SecurityManagement.Infrastructure.ViewModel;

namespace SecurityManagement.Views
{    
    public partial class frmCF : ViewTab
    {       
        private List<vm> CFType = new List<vm>();
        public frmCF()
        {
            InitializeComponent();

            CFType.Add(new vm { Id = 1,Name = "CF-800" });
            CFType.Add(new vm { Id = 2,Name = "CF-801-1" });
            CFType.Add(new vm { Id = 3,Name = "CF-801-3" });
            CFType.Add(new vm { Id = 4,Name = "CF-803" });
            CFType.Add(new vm { Id = 5,Name = "CF-806" });
            CFType.Add(new vm { Id = 6,Name = "CF-808" });
            CFType.Add(new vm { Id = 7,Name = "CF-809" });

            lookUpEdit1.Fill(CFType.ToDataTable<vm>(), "Name", "Id");




        }
    }
}
