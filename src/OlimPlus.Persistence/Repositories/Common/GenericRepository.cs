using Microsoft.EntityFrameworkCore;
using OlimPlus.Application.Contracts.Persistence.Common;
using OlimPlus.Application.Exceptions;
using OlimPlus.Domain.Entity.Common;
using OlimPlus.Persistence.DatabaseContext;

namespace OlimPlus.Persistence.Repositories.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly OlimPlusDatabaseContext _context;

        public GenericRepository(OlimPlusDatabaseContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var data = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(q => q.Id == id);
            if (data is null)
            {
                throw new NotFoundException(nameof(T), id);
            }

            return data;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}