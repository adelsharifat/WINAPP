using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMISUtils;
using Security;

namespace CMISUIHelper.UserControls
{
    public partial class ViewTabWithCompany : ViewTab
    {
        public ViewTabWithCompany()
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

        private string aclCompany;

        public string AclCompanyCombo
        {
            get { return aclCompany; }
            set { aclCompany = value; }
        }



        #endregion
        #region Method
        public virtual void InitComboCompany()
        {
            
        }
        #endregion
    }
}
