using CMISDAL.Interfaces;
using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISDAL.Base
{
    public sealed class CMISConnection : ICMISConnection
    {
        private string connectionString;
        private SqlConnection sqlConnection;
        public CMISConnection()
        {
            connectionString = ConnectionST.GetConnectionString();
            sqlConnection = new SqlConnection(connectionString);
        }

        public CMISConnection(string connectionString)
        {
            this.connectionString = connectionString;
            sqlConnection = new SqlConnection(this.connectionString);
        }

        public string ConnectionString { get => this.connectionString; set => this.connectionString = value; }

        public int ConnectionTimeout => this.Connection.ConnectionTimeout;

        public string Database => this.Connection.Database;

        public ConnectionState State => this.Connection.State;

        public SqlConnection Connection { get => this.sqlConnection; }


        private SqlTransaction transaction;
        public SqlTransaction Transaction {
            get
            {
                if(transaction == null)
                    transaction = this.Connection.BeginTransaction();
                return transaction;                 
            }
        }

        public IDbTransaction BeginTransaction() => this.Connection.BeginTransaction();

        public IDbTransaction BeginTransaction(IsolationLevel il) => this.Connection.BeginTransaction();

        public void ChangeDatabase(string databaseName) => this.Connection.ChangeDatabase(databaseName);        

        public IDbCommand CreateCommand() => this.Connection.CreateCommand();

        public SqlCommand CreateCommand(string command, SqlParameter[] sqlParameters = null)
        {
            SqlCommand cmd = this.Connection.CreateCommand();
            cmd.CommandText = command;
            if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
            return cmd;
        }

        public SqlCommand CreateCommand(string command, CommandType commandType,SqlParameter[] sqlParameters = null)
        {
            var cmd = this.Connection.CreateCommand();
            cmd.CommandText = command;
            cmd.CommandType = commandType;
            if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
            return cmd;
        }
       
        public void Open()
        {
            if (this.State != ConnectionState.Open)
                this.Connection.Open();
        }

        public async Task OpenSafeAsync()
        {
            if (this.State != ConnectionState.Open)
                await this.Connection.OpenAsync();
        }

        public void Close()
        {
            if (this.State != ConnectionState.Closed) this.Connection.Close();
        }

        public void Dispose()
        {
            if (this.Connection != null && this.State == ConnectionState.Closed)
                this.Connection.Dispose();
        }

    }
}
