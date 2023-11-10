using Microsoft.EntityFrameworkCore;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Domain.Entity;
using OlimPlus.Persistence.DatabaseContext;
using OlimPlus.Persistence.Repositories.Common;

namespace OlimPlus.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly OlimPlusDatabaseContext _context;

        public CategoryRepository(OlimPlusDatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsCategoryUnique(string name)
        {
            return await _context.Categories.AnyAsync(q => q.CategoryName == name);
        }
    }
}