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
                return DoQueryReader("CM.FetchUserById", parameters);                
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
                return DoQueryReader("CM.FetchGroupById", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] FetchAvatarByUserId(int userId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Id",userId),
                    new SqlParameter
                    {
                        ParameterName = "@Avatar",
                        Direction = ParameterDirection.Output,
                        SqlDbType = SqlDbType.VarBinary,
                        Size = -1
                    }
                };
                DoQueryReader("CM.FetchAvatarByUserId", parameters);
                var val = parameters.FirstOrDefault(x => x.ParameterName == "@Avatar").Value;
                var avatar = val == null ? null : (byte[])val;
                return avatar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
