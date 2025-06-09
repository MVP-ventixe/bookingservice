using Infrastructure.Models;

namespace Infrastructure.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<RepositoryResult<TEntity>> AddAsync(TEntity entity);
        Task<RepositoryResult<bool>> DeleteAsync(TEntity entity);
        Task<RepositoryResult<IEnumerable<TEntity>>> GetAllAsync();
        Task<RepositoryResult<TEntity?>> GetByIdAsync(object id);
        Task<RepositoryResult<bool>> UpdateAsync(TEntity entity);
    }
}