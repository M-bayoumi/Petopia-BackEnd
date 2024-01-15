using Microsoft.EntityFrameworkCore.Storage;

namespace Petopia.Infrastructure.Repositories.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        IQueryable<T?> GetTableNoTracking();
        IQueryable<T?> GetTableAsTracking();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(ICollection<T> entities);
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
    }
}
