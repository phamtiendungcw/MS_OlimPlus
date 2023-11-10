using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                new Address()
                {
                    Id = 1,
                    Address1 = "Kim Binh",
                    City = "Phu Ly",
                    Province = "Ha Nam",
                    Country = "Viet Nam",
                    IsMain = true,
                    PostalCode = "100000",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
        }
    }
}