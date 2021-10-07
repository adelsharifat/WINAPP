using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper.UserControls
{
    public partial class ViewForm : UserControl
    {
        public event EventHandler BeforeViewLoad;
        public event EventHandler ViewLoaded;
        public ViewForm()
        {
            InitializeComponent();
        }

        public void OnBeforeViewLoad(EventArgs e)
        {
            this.BeforeViewLoad?.Invoke(this, e);
        }


        public void OnViewLoaded(EventArgs e)
        {         
            this.ViewLoaded?.Invoke(this, e);
        }

        public string ViewTitle { get; set; }
    }
}
