using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shoppy.Catalog.Persistence.EF.Extensions
{
    public static class PersistenceServicesExtension
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services,
            IConfiguration configurations)
        {
            services.AddDbContext<CatalogDbContext>(builder =>
            {
                var connectionString = configurations.GetConnectionString(nameof(CatalogDbContext));
                builder.UseSqlServer(connectionString,
                    x => x.MigrationsHistoryTable("__EFMigrationsHistory", Schema.Catalog));
                builder.EnableSensitiveDataLogging();
            });

            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}