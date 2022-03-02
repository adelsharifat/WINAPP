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
        public static DAL Do { get => new DAL(); }

        #region Common
        //Fetch compnies data for combo company
        public DataTable FetchCompaniesData()
        {
            try
            {
                return DoQueryReader("SecAcl.FetchCompaniesData");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Fetch contract data for combo contract
        public DataTable FetchContractsData()
        {
            try
            {
                return DoQueryReader("SecAcl.FetchContractsData");
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public DataTable FetchDisciplineForAcls(int projectId, bool? isDiscipline = null)
        {
            try
            {
                SqlParameter[] parameters =
                   {
                        new SqlParameter("@ProjectId",projectId),
                        new SqlParameter("@IsDiscipline", isDiscipline),
                    };
                return DoQueryReader("SecAcl.FetchDisciplineForAcls", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion




        public DataTable GetUserList()
        {
            try
            {           
                return DoQueryReader("SecAcl.GetUserList");                
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
                return DoQueryReader("SecAcl.GetUserGroupList", parameters);                
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
                    return DoQueryReader("SecAcl.FetchACL", parameters);
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
                return DoQueryReader("GetProjectList");
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
