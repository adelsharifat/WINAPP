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
    public class dalServer:APPDAL
    {
        public DateTime ServerDateTime(bool dateWithTime = false)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@DateWithTime",dateWithTime),
                    new SqlParameter{
                        ParameterName = "@ServerDateTime",
                        SqlDbType = SqlDbType.DateTime,
                        Direction = ParameterDirection.Output
                    }
                };
                DoMutation("CM.FetchServerDateTime", parameters);
                var val = parameters.FirstOrDefault(p => p.ParameterName == "@ServerDateTime").Value;
                var result = Convert.ToDateTime(val);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
