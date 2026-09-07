using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechAI.DataAccess;

public static class ServiceRegistration
{
    public static IServiceCollection AddDataAccessService(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<TechAIDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlConnection"), b => b.MigrationsAssembly(typeof(TechAIDbContext).Assembly.FullName));
        });

        return service;
    }
}
