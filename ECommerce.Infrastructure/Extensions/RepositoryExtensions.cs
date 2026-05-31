using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Migrations;
using ECommerce.Infrastructure.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure.Extensions
{
    /// <summary>
    /// RepositoryExtensions
    /// </summary>
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringOption>(configuration.GetSection(ConnectionStringOption.Key));

            services.AddDbContext<AppDbContext>(options =>
            {
                var connectionString = configuration
                    .GetSection(ConnectionStringOption.Key)
                    .Get<ConnectionStringOption>();

                options.UseSqlServer(connectionString!.SqlServer, sql =>
                {
                    sql.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                });
            });

            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();

            return services;
        }
    }
}
