using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMISControl
{

    public partial class FormMode : UserControl
    {
        

        public FormMode()
        {
            InitializeComponent();
        }


        public void SetSaveMode()
        {
            lblFormState.Text = "SAVE MODE";
            lblFormState.BackColor = Color.DodgerBlue;
            lblFormState.ForeColor = Color.White;
        }

        public void SetEditMode()
        {
            lblFormState.Text = "EDIT MODE";
            lblFormState.BackColor = Color.Gold;
            lblFormState.ForeColor = Color.Black;
        }

        public void SetViewMode()
        {
            lblFormState.Text = "VIEW MODE";
            lblFormState.BackColor = Color.FromArgb(210,215,220);
            lblFormState.ForeColor = Color.Black;
        }

        public void ShowDraft()
        {
            lblDraft.Visible = true;
            lblDraft.BackColor = Color.FromArgb(33,33,33);
            lblDraft.ForeColor = Color.White;            
        }

        public void HideDraft()
        {
            lblDraft.Visible = false;
        }


    }
}
