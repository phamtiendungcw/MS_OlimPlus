using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlimPlus.Persistence.DatabaseContext;

namespace OlimPlus.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OlimPlusContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("OlimPlusConnectionString"));
            });

            return services;
        }
    }
}
