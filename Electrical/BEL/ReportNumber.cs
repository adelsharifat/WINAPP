using CMISBEL.Core.Common;
using CMISUtils.Extentions;
using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical.BEL
{
    public static class ReportNumber
    {
        public static string MIVReportNumber(int employerId,string companySymbol)
        {
            try
            {
                var disciplineId = belConfig.Do.Config(LoginInfo.ProjectId,Bundle.SCHEMA)["DisciplineId"].ToInt();
                var empId = employerId;
                var reportSyntax = "{[CompanySymbol]}," + companySymbol;
                var report = DMS.ReportNumber.Do.Generate("EL.MIV", LoginInfo.ProjectId, disciplineId, empId, null, reportSyntax);
                return report.ReportNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string PLReportNumber(int employerId)
        {
            try
            {
                var disciplineId = belConfig.Do.Config(LoginInfo.ProjectId, Bundle.SCHEMA)["DisciplineId"].ToInt();
                var empId = employerId;
                var report = DMS.ReportNumber.Do.Generate("EL.PL", LoginInfo.ProjectId, disciplineId, empId, null);
                return report.ReportNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
