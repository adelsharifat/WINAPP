using CMISUIHelper.Infrastructure.Helpers;
using CMISUIHelper.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piping.Views
{
    public partial class Home : ViewBase
    {
        public Home()
        {
            InitializeComponent();
            ViewTitle = "Home";
            
        }

        private void Home_ViewLoaded(object sender, EventArgs e)
        {
            textEdit1.AddBadge(OwnerForm.BadgeManager,Color.DodgerBlue,Color.White).SetText("1").SetLocation(ContentAlignment.TopRight);
        }
    }
}
