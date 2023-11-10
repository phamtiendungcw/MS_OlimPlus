using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.Contracts.Persistence.Common;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories;
using OlimPlus.Persistence.Repositories.Common;

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
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
            services.AddScoped<IOrderInfoRepository, OrderInfoRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IProductAttributeRepository, ProductAttributeRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}