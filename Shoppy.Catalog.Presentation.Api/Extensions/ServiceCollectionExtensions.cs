using Shoppy.Catalog.Application.Extensions;
using Shoppy.Catalog.Domain.Extensions;
using Shoppy.Catalog.Persistence.EF.Extensions;

namespace Shoppy.Catalog.Presentation.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCatalogService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDomainServices(configuration);
            services.AddApplicationService(configuration);
            services.AddPersistenceService(configuration);
        }
    }
}
