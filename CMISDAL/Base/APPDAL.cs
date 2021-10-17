using CMISDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CMISDAL.Base
{
    public class APPDAL:CMISDbContext
    {
        protected override DataTable DoQuery(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                using (ICMISConnection connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType, sqlParameters))
                    {
                        connection.Open();
                        var reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        connection.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override object DoScalar(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                using (ICMISConnection connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType, sqlParameters))
                    {
                        connection.Open();
                        var obj = cmd.ExecuteScalar();
                        connection.Close();
                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override async Task<DataTable> DoQueryAsync(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                using (ICMISConnection connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType, sqlParameters))
                    {
                        await connection.OpenSafeAsync();
                        var reader = await cmd.ExecuteReaderAsync();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        connection.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override async Task<object> DoScalarAsync(string command, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                using (ICMISConnection connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType))
                    {
                        await connection.OpenSafeAsync();
                        var obj = await cmd.ExecuteScalarAsync();
                        connection.Close();
                        return obj;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override int DoMutation(string command, SqlParameter[] sqlParameters = null, bool withTransaction = false, CommandType commandType = CommandType.StoredProcedure)
        {
            CMISConnection connection = null;
            try
            {
                using (connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType, sqlParameters))
                    {
                        connection.Open();
                        if (withTransaction) cmd.Transaction = connection.Transaction;
                        var result = cmd.ExecuteNonQuery();                       
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                connection?.Transaction?.Rollback();
                connection?.Transaction?.Dispose();
                throw ex;
            }
            finally
            {
                connection?.Close();
            }
        }
        protected override async Task<int> DoMutationAsync(string command, SqlParameter[] sqlParameters = null, bool withTransaction = false, CommandType commandType = CommandType.StoredProcedure)
        {
            CMISConnection connection = null; 
            try
            {
                using (connection = new CMISConnection())
                {
                    using (var cmd = connection.CreateCommand(command, commandType, sqlParameters))
                    {
                        await connection.OpenSafeAsync();
                        if (withTransaction) cmd.Transaction = connection.Transaction;
                        var result = await cmd.ExecuteNonQueryAsync();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                connection?.Transaction?.Rollback();
                connection?.Transaction?.Dispose();
                throw ex;
            }
            finally
            {
                connection?.Close();
            }
        }
        public void DoTransaction(Action transActionFunc)
        {
            TransactionScope trans = null;
            try
            {
                using ( trans = new TransactionScope())
                {
                    transActionFunc.Invoke();
                    trans?.Complete();
                }
                    
            }
            catch (Exception ex)
            {               
                throw ex;
            }
            finally
            {
                trans?.Dispose();
            }
        }
    }
}
