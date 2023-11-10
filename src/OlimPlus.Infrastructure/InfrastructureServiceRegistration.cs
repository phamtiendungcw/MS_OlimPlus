using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlimPlus.Application.Contracts.Logging;
using OlimPlus.Infrastructure.Logging;

namespace OlimPlus.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}