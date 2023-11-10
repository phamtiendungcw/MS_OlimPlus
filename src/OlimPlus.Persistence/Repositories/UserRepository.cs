using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}