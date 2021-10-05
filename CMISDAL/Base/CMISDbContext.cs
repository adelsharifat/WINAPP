using CMISDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Base
{
    public abstract class CMISDbContext 
    {

        protected abstract DataTable DoQuery(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure);
        protected abstract object DoScalar(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure);
        protected abstract Task<DataTable> DoQueryAsync(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure);
        protected abstract Task<object> DoScalarAsync(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure);

        protected abstract int DoMutation(string command, SqlParameter[] sqlParameters = null, bool withTransaction = false, CommandType commandType = CommandType.StoredProcedure);
        protected abstract Task<int> DoMutationAsync(string command, SqlParameter[] sqlParameters = null, bool withTransaction = false, CommandType commandType = CommandType.StoredProcedure);
     }
}
