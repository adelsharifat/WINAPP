using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Interfaces
{
    public interface ICMISConnection:IDbConnection
    {
        Task OpenSafeAsync();
        SqlConnection Connection { get; }        
        SqlCommand CreateCommand(string command, SqlParameter[] sqlParameters= null);
        SqlCommand CreateCommand(string command, CommandType commandType, SqlParameter[] sqlParameters = null);
        SqlTransaction Transaction { get; }




    }
}
