using TechAI.Domain.Entities;
using TechAI.Domain.IRepositories;

namespace TechAI.DataAccess.Repositories;

public class AboutRepository(TechAIDbContext _context) : GenericRepository<About>(_context), IAboutRepository
{
}
