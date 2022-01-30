using CMISDAL.Base;
using QCElectrical.Infrastructure;
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
        public DataTable FetchCFItems(CFType cfType,int? cfId = null)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("CfTypeId",(int)cfType),
                    new SqlParameter("CfId",cfId),
                };
                return DoQueryAdapter("QCEL.FetchCFItems", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FetchAttachments(int objectId)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("ObjectId",objectId),
                };
                return DoQueryAdapter("QCEL.FetchAttachments", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataRow FetchCF_819(int documentId, CFType cfType)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("DocumentId",documentId),
                    new SqlParameter("CfTypeId",(int)cfType),
                };
                var dt = DoQueryReader("QCEL.FetchCF_819", parameters);
                if (dt.Rows.Count > 0) return dt.Rows[0] as DataRow;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int SaveCF_WithFixedItems(int id,int projectId,int employerId,int contractId,int contractorId,int userId,string objectName,CFType cfType, int revisionId,int unitId,string remark = null,string revNo = null,string location = null,int? voltageCableType = null,string reportNoParameters = null,DataTable attachments = null,DataTable itemsResult = null)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("Id",id),
                    new SqlParameter("CFTypeId",(int)cfType),
                    new SqlParameter("ProjectId",projectId),
                    new SqlParameter("EmployerId",employerId),
                    new SqlParameter("ContractId",contractId),
                    new SqlParameter("ContractorId",contractorId),
                    new SqlParameter("UserId",userId),
                    new SqlParameter("ObjectName",objectName),
                    new SqlParameter("Type2",cfType.ToString()),
                    new SqlParameter("RevisionId",revisionId),
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

        public int DeleteCFDocument(int documentId, int userId)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("DocumentId",documentId),
                    new SqlParameter("UserId",userId),
                };
                return DoMutation("QCEL.DeleteCFDocument", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FETCH_CF_LIST(int projectId)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("ProjectId",projectId),
                };
                return DoQueryReader("QCEL.FETCH_CF_LIST", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}
