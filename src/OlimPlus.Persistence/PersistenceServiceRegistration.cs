using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlimPlus.Application.Contracts.Common;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories;

namespace OlimPlus.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<OlimPlusDatabaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("OlimPlusConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}