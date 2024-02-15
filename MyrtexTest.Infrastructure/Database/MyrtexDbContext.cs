using Microsoft.EntityFrameworkCore;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Infrastructure.Database;

public sealed class MyrtexDbContext : DbContext
{
    public MyrtexDbContext(DbContextOptions<MyrtexDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Employee> Employees { get; set; }
}
