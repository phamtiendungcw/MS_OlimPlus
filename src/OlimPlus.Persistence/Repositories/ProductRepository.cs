using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}