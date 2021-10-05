using CMISUIHelper.Infrastructure.Contracts.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMISUIHelper.Infrastructure.Extention
{
    public static class ExceptionExtentionMethod
    {
        public static void ShowMesssage(this Exception ex)
        {
            if (ex is CMISException)
                MessageBox.Show(ex.Message, "CMIS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(ex.Message, "System Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
