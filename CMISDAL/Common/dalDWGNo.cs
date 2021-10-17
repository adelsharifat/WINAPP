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
    public class dalDWGNo:APPDAL
    {
        public DataTable FetchDWGNo()
        {
            try
            {
                SqlParameter[] parameters =
                {
                };
                return DoQuery("CM.[FetchDWGNo]", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
