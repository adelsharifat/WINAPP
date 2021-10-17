using CMISDAL.Base;
using DMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS
{
    public class ReportNumber:APPDAL
    {
        public static ReportNumber Do { get; private set; } = new ReportNumber();
        public ReportNumberViewModel Generate(string objectName, int projectId, int? disciplineId = null, int? employerId = null, int? companyId = null, string reportparameters = null)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ObjectName",objectName),
                    new SqlParameter("@ProjectId",projectId),
                    new SqlParameter("@DisciplineId",disciplineId),
                    new SqlParameter("@EmployerId",employerId),
                    new SqlParameter("@CompanyId",companyId),
                    new SqlParameter("@Parameters",reportparameters),
                    new SqlParameter{
                       ParameterName = "@CounterId",
                       SqlDbType = SqlDbType.Int,
                       Direction = ParameterDirection.Output
                    },
                     new SqlParameter{
                       ParameterName = "@ReportNumber",
                       SqlDbType = SqlDbType.VarChar,
                       Size = -1,
                       Direction = ParameterDirection.Output
                    }
                };
                DoMutation("CM.GenerateReportNumber", parameters);
                var counterId = parameters.FirstOrDefault(p => p.ParameterName == "@CounterId").Value;
                var reportNumber = parameters.FirstOrDefault(p => p.ParameterName == "@ReportNumber").Value;

                ReportNumberViewModel reportNumberViewModel = new ReportNumberViewModel
                {
                    CounterId = counterId == null ? 0 : Convert.ToInt32(counterId),
                    ReportNumber = reportNumber == null ? null : Convert.ToString(reportNumber)
                };

                return reportNumberViewModel;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Increment(int counterId)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@CounterId",counterId),
                };
                DoMutation("CM.IncrementReportNumber", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
