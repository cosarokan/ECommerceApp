using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerce.Infrastructure.Migrations
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Address> Addresses { get; set; } = default!;
        public DbSet<AddressType> AddressTypes { get; set; } = default!;
        public DbSet<Brand> Brands { get; set; } = default!;
        public DbSet<BrandModel> BrandModels { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<City> Cities { get; set; } = default!;
        public DbSet<Comment> Comments { get; set; } = default!;
        public DbSet<CustomerProfile> CustomerProfiles { get; set; } = default!;
        public DbSet<District> Districts { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderStatus> OrderStatuses { get; set; } = default!;
        public DbSet<PaymentType> PaymentTypes { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ProductAttribute> ProductAttributes { get; set; } = default!;
        public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; } = default!;
        public DbSet<Role> Roles { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<UserRole> UserRole { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
