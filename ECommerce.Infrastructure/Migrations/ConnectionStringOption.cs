namespace ECommerce.Infrastructure.Migrations
{
    /// <summary>
    /// ConnectionStringOption
    /// </summary>
    public class ConnectionStringOption
    {
        /// <summary>
        /// Key
        /// </summary>
        public const string Key = "ConnectionStrings";

        /// <summary>
        /// SqlServer
        /// </summary>
        public string SqlServer { get; set; } = default!;
    }
}
