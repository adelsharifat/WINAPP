using CMISDAL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCElectrical.Data
{
    public class DAL:APPDAL
    {
        public static DAL New { get => new DAL(); }

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

    }
}
