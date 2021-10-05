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
    public class dalUser:APPDAL
    {
        public DataTable GetUserById(string procedure, int userId)
        {
            try
            {                
                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId",userId)
                };
                return DoQuery("CM.FetchUserById", parameters);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetGroupById(int groupId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@GroupId",groupId)
                };
                return DoQuery("CM.FetchGroupById", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
