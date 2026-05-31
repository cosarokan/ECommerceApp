using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure.DependencyInjection
{
    /// <summary>
    /// ServiceRegistration
    /// </summary>
    public static class ServiceRegistration
    {
        /// <summary>
        /// AddInfrastructure
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();

            return services;
        }
    }
}
