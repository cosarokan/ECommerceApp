using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Migrations;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace ECommerce.Infrastructure.Repositories.Implementations
{
    /// <summary>
    /// DbConnectionFactory
    /// </summary>
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        /// <summary>
        /// DbConnectionFactory
        /// </summary>
        /// <param name="options"></param>
        public DbConnectionFactory(IOptions<ConnectionStringOption> options)
        {
            _connectionString = options.Value.SqlServer;
        }

        /// <summary>
        /// CreateConnection
        /// </summary>
        /// <returns></returns>
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
