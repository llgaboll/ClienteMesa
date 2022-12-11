using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigloXXI.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string connectionString;

        public RepositoryBase()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sigloXXI"].ConnectionString;
        }
        protected OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
    }
}
