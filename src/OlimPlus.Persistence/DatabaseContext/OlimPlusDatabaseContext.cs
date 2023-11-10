using Microsoft.EntityFrameworkCore;
using OlimPlus.Domain.Entity;
using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Persistence.DatabaseContext
{
    public class OlimPlusDatabaseContext : DbContext
    {
        public OlimPlusDatabaseContext(DbContextOptions<OlimPlusDatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(typeof(OlimPlusDatabaseContext).Assembly);
            base.OnModelCreating(modelbuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                         .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
            {
                entry.Entity.UpdatedAt = DateOnly.FromDateTime(DateTime.Now);

                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedAt = DateOnly.FromDateTime(DateTime.Now);
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}