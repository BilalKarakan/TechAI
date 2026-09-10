using TechAI.Domain.Entities;

namespace TechAI.Domain.IRepositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IList<T>> GetListAsync(CancellationToken cancellationToken = default);
    Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    void Update(T entity);
    void Delete(T entity);
}
