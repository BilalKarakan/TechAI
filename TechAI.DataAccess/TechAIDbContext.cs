using Microsoft.EntityFrameworkCore;
using TechAI.Domain.Entities;

namespace TechAI.DataAccess;

public class TechAIDbContext : DbContext
{
    public TechAIDbContext(DbContextOptions<TechAIDbContext> options) : base(options)
    {
        
    }

    public DbSet<About> Abouts => Set<About>();
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Video> Videos => Set<Video>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAIDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
