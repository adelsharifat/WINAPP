using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Core.Common
{
    public class dalProject:APPDAL
    {
        public DataTable GetProjectList()
        {
            try
            {
                SqlParameter[] parameters = { };
                return DoQueryReader("SecAcl.GetProjectList", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
