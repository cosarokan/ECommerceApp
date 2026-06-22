using ECommerce.Application.Common;
using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Repositories.Implementations;
using ECommerce.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
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
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var redisConnection = configuration["Redis:ConnectionString"];
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();     
            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisConnection!));
            services.AddScoped<ICacheService, CacheService>();
            services.Configure<JwtOption>(configuration.GetSection(JwtOption.Key));

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
