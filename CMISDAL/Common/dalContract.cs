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
    public class dalContract:APPDAL
    {
        public DataTable FetchContractsCombo(int userId, int projectId, string acl)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId),
                    new SqlParameter("@UserId",userId),
                    new SqlParameter("@Acl",acl),
                };
                return DoQuery("CM.[FetchContractsCombo]", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
