using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories.Implementations
{
    /// <summary>
    /// UserRepository
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// ExistsByEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> ExistsByEmailAsync(string email)
        {
            return _context.Users.AnyAsync(x => x.Email.Equals(email));
        }

        /// <summary>
        /// GetByEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<User?> GetByEmailAsync(string email)
        {
            return _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email));
        }
    }
}
