using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Common
{
    public class dalAreaUnit:APPDAL
    {
        public DataTable FetchAreaUnitCombo(int projectId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId),
                };
                return DoQueryAdapter("CM.[FetchAreaUnitCombo]", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
