using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Domain.Model;
using MyrtexTest.Infrastructure.Database;
using MyrtexTest.Infrastructure.Repository;

namespace MyrtexTest.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMyrtexDbContext(configuration);
        
        services.AddRepositories();
    }
    
    private static void AddMyrtexDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("PostgreSQL");

        // todo: lifetime?
        services.AddDbContext<MyrtexDbContext>(x => x.UseNpgsql(connectionString));
    }
    
    private static void AddRepositories(this IServiceCollection services)
    {
        // todo: add repos from assembly?
        // todo: Transient, Scoped or Singleton for repository?
        services.AddScoped<IRepository<Employee>, EmployeeRepository>();
    }
}
