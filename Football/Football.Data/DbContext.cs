using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data
{
    public class DbContext
    {
        private readonly IDbConnection connection;
        private readonly IConnectionFactory connectionFactory;

        public DbContext(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
            connection = connectionFactory.Create();
        }

        public IDbCommand CreateCommand()
        {
            var cmd = connection.CreateCommand();

            return cmd;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
