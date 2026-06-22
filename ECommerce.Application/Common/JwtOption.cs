namespace ECommerce.Application.Common
{
    /// <summary>
    /// JwtOption
    /// </summary>
    public class JwtOption
    {
        public const string Key = "Jwt";

        /// <summary>
        /// Issuer
        /// </summary>
        public string Issuer { get; set; } = null!;

        /// <summary>
        /// Audince
        /// </summary>
        public string Audience { get; set; } = null!;

        /// <summary>
        /// SecretKey
        /// </summary>
        public string SecretKey { get; set; } = null!;

        /// <summary>
        /// Expiration
        /// </summary>
        public int Expiration { get; set; }
    }
}
