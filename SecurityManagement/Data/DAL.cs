using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManagement.Data
{
    public class DAL:APPDAL
    {
        public static DAL New { get => new DAL(); }

        public DataTable GetUserList()
        {
            try
            {           
                return DoQuery("SecAcl.GetUserList");                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public DataTable GetUserGroupList(int projectId)
        {
            try
            {                
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ProjectId",projectId)
                };
                return DoQuery("SecAcl.GetUserGroupList", parameters);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FetchAcls(int id, int projectId, bool isGroup)
        {
            try
            {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Id",id),
                        new SqlParameter("@ProjectId",projectId),
                        new SqlParameter("@IsGroup",isGroup),
                    };
                    return DoQuery("SecAcl.FetchACL", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetProjectList()
        {
            try
            {
                return DoQuery("GetProjectList");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FetchCompaniesData()
        {
            try
            {
                return DoQuery("SecAcl.FetchCompaniesData");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveChangeACL(int projectId, int id, DataTable acls, bool isGroup)
        {
            try
            {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@ProjectId",projectId),
                        new SqlParameter("@Id",id),
                        new SqlParameter("@Acls",acls),
                        new SqlParameter("@IsGroup",isGroup)
                    };
                    return DoMutation("SecAcl.SaveChangeACL", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
