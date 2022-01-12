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
    public class dalPermision:APPDAL
    {
        public DataTable FetchUserPermission(int projectId,int userId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                };
                return DoQueryReader("CM.[FetchUserPermisions]", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
