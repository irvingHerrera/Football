using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data
{
    public class DbConnectionFactory : IConnectionFactory
    {
        private readonly DbProviderFactory provider;
        private readonly string connectionString;
        private readonly string name;

        public DbConnectionFactory(string connectionName)
        {
            if (connectionName == null) throw new ArgumentNullException("connectionName");

            var conStr = ConfigurationManager.ConnectionStrings[connectionName];
            if (conStr == null)
                throw new ConfigurationErrorsException(string.Format("Failed to find connection string named '{0}' in app/web.config.", connectionName));

            name = conStr.ProviderName;
            provider = DbProviderFactories.GetFactory(conStr.ProviderName);
            connectionString = conStr.ConnectionString;
        }

        public IDbConnection Create()
        {
            var connection = provider.CreateConnection();
            if (connection == null)
                throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", name));

            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
    }
}
