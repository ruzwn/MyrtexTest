using Microsoft.EntityFrameworkCore;

namespace MyrtexTest.Infrastructure.Database;

public sealed class MyrtexDbContext : DbContext
{
    public MyrtexDbContext(DbContextOptions<MyrtexDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}
