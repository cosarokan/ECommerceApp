using System.Data;

namespace ECommerce.Application.Interfaces
{
    /// <summary>
    /// IDbConnectionFactory
    /// </summary>
    public interface IDbConnectionFactory
    {
        /// <summary>
        /// CreateConnection
        /// </summary>
        /// <returns></returns>
        IDbConnection CreateConnection();
    }
}
