using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Framework.Data
{
    public class DataGateWay
    {
        #region Data Access Variables
        private string _connstring = "";
        private string _providerName = "";
        private DbTransaction _transaction;
        private DbProviderFactory _factory;
        #endregion

        #region Constructor
        public DataGateWay(string connectionName)
        {
            _connstring = 
                ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            _providerName = 
                ConfigurationManager.ConnectionStrings[connectionName].ProviderName;
            _factory = DbProviderFactories.GetFactory(_providerName);
        }
        #endregion

        #region ExecuteTransaction
        public int ExecuteTransaction(string sql, IDataParameter[] pars, CommandType commType)
        {
            int rowAffected;
            try
            {
                using (var conn = _factory.CreateConnection())
                {
                    conn.ConnectionString = _connstring;
                    using (var comm = _factory.CreateCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = sql;
                        comm.CommandType = commType;
                        if(pars != null)
                        {
                            comm.Parameters.AddRange(pars);
                        }
                        conn.Open();
                        _transaction = conn.BeginTransaction();
                        comm.Transaction = _transaction;
                        rowAffected = comm.ExecuteNonQuery();
                        _transaction.Commit();
                    }
                }
            }
            catch(Exception ex)
            {
                _transaction.Rollback();
                throw new Exception("Error Transmitting Data to Database !", ex);
            }
            return rowAffected;
        }
        #endregion

        #region Execute Query return IDataReader
        public IDataReader ExecuteQuery(string sql, IDbDataParameter[] pars,CommandType commType)
        {
            try
            {
                var conn = _factory.CreateConnection();
                conn.ConnectionString = _connstring;
                var comm = _factory.CreateCommand();
                comm.Connection = conn;
                comm.CommandText = sql;
                comm.CommandType = commType;
                if(pars != null)
                {
                    comm.Parameters.AddRange(pars);
                }
                conn.Open();
                var reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Executing Query ! Please contact database administrator.", ex);
            }
        }
        #endregion

        #region IDataParameter object
        public IDataParameter CreateParameter => _factory.CreateParameter();    
        #endregion
    }
}
