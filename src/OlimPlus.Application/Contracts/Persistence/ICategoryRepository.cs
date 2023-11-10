using OlimPlus.Application.Contracts.Persistence.Common;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<bool> IsCategoryUnique(string name);
    }
}