using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Migrations;

namespace ECommerce.Infrastructure.Repositories.Implementations
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context): base(context)
        {
        }
    }
}
