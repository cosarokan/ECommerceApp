using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// GetByEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User?> GetByEmailAsync(string email);

        /// <summary>
        /// ExistsByEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> ExistsByEmailAsync(string email);
    }
}
