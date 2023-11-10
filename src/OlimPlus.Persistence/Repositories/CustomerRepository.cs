using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}