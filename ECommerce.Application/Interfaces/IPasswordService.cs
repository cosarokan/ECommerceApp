namespace ECommerce.Application.Interfaces
{
    /// <summary>
    /// IPasswordService
    /// </summary>
    public interface IPasswordService
    {
        /// <summary>
        /// Hash
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string Hash(string password);

        /// <summary>
        /// Verify
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        bool Verify(string password, string passwordHash);
    }
}
