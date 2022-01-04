using CMISDAL.Base;
using CMISDAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Core.Common
{
    public class dalConfig : APPDAL
    {
        public DataTable FetchConfig(int projectId,string scope)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId),
                    new SqlParameter("@Scope",scope)
                };
                return DoQueryReader("CM.[FetchConfig]", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
