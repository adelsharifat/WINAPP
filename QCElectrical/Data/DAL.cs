using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical.Data
{
    public class DAL:APPDAL
    {
        public static DAL Do { get => new DAL(); }

        #region Common
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

        public DataTable FetchContractsData()
        {
            try
            {
                return DoQuery("SecAcl.FetchContractsData");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FetchCFCombo()
        {
            try
            {
                return DoQuery("QCElectrical.FetchCFCombo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region CFItems
        public DataTable FetchCFItems(int cfTypeId)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("CFTypeId",cfTypeId),
                };
                return DoQuery("QCElectrical.FetchCFItems", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCFItems(int projectId,int userId,DataTable data)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("CFItems",data)
                };
                return DoMutation("QCElectrical.SaveCFItems", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
