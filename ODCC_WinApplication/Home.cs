using System;
using System.Windows.Forms;

namespace ODCC_WinApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Piping.Main.MainForm mainForm = new Piping.Main.MainForm();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecurityManagement.Main.frmMain mainForm = new SecurityManagement.Main.frmMain();
            mainForm.Show();
        }
    }
}
