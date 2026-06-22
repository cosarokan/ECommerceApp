using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces
{
    /// <summary>
    /// ITokenService
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string CreateToken(User user);
    }
}
