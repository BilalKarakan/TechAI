using Microsoft.EntityFrameworkCore;
using TechAI.Domain.Entities;
using TechAI.Domain.IRepositories;

namespace TechAI.DataAccess.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly TechAIDbContext _context;
    public GenericRepository(TechAIDbContext context) => _context = context;
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default) => await _context.Set<T>().AddAsync(entity, cancellationToken);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);

    public async Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default) => await _context.Set<T>().FindAsync(id, cancellationToken);

    public async Task<IList<T>> GetListAsync(CancellationToken cancellationToken = default) => await _context.Set<T>().AsNoTracking().ToListAsync(cancellationToken);

    public void Update(T entity) => _context.Set<T>().Update(entity);
}
