using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}