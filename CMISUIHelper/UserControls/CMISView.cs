using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper.UserControls
{
    public partial class CMISView : ViewBase
    {
        public CMISView()
        {
            InitializeComponent();
        }

        #region Propertied
        private string companyLable;

        public string CompanyComboLabel
        {
            get { return companyLable; }
            set { companyLable = value; }
        }

        public Color CompanyComboBackColor
        {
            get {
                return this.pnlCompanyCombo.BackColor;
            }
            set {
                this.pnlCompanyCombo.BackColor = value;
            }
        }



        #endregion
    }
}
