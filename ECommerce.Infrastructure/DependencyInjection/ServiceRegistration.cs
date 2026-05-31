using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

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
            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect("localhost:6379"));
            services.AddScoped<ICacheService, CacheService>();
   
            return services;
        }
    }
}
