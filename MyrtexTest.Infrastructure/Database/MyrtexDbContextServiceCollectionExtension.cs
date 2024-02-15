using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyrtexTest.Infrastructure.Database;

public static class MyrtexDbContextServiceCollectionExtension
{
    public static void AddMyrtexDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("PostgreSQL");

        var optionsBuilder = new DbContextOptionsBuilder<MyrtexDbContext>();
        optionsBuilder.UseNpgsql(connectionString);
    }
}
