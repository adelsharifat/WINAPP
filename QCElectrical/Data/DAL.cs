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
                return DoQueryReader("SecAcl.FetchCompaniesData");
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
                return DoQueryReader("SecAcl.FetchContractsData");
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
                return DoQueryReader("QCElectrical.FetchCFCombo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region CF-819-1
        public DataTable FetchCFItems(string cfType)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("CfType",cfType),
                };
                return DoQueryAdapter("QCEL.FetchCFItems", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveCF_WithFixedItems(int id,int projectId,int employerId,int contractId,int contractorId,int userId,string objectName,string type2, string dwgNo,int unitId,string remark = null,string revNo = null,string location = null,int? voltageCableType = null,string reportNoParameters = null,DataTable attachments = null,DataTable itemsResult = null)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("Id",id),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("EmployerId",employerId),
                    new SqlParameter("ContractId",contractId),
                    new SqlParameter("ContractorId",contractorId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("ObjectName",objectName),
                    new SqlParameter("Type2",type2),
                    new SqlParameter("DwgNo",dwgNo),
                    new SqlParameter("UnitId",unitId),
                    new SqlParameter("Remark",remark),
                    new SqlParameter("RevNo",revNo),
                    new SqlParameter("Location",location),
                    new SqlParameter("VoltageCableType",voltageCableType),
                    new SqlParameter("ReportNoParameters",reportNoParameters),
                    new SqlParameter("Attachments",attachments),
                    new SqlParameter("ItemsResult",itemsResult)
                };
                return DoMutation("QCEL.SaveCF_WithFixedItems", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public DataTable FETCH_CF_801_19_1_LIST(int projectId)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("ProjectId",projectId),
                };
                return DoQueryReader("QCEL.FETCH_CF_801_19_1_LIST", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}
