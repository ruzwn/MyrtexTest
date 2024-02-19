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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // todo: all is ok ???
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyrtexDbContext).Assembly);
    }

    public DbSet<Employee> Employees { get; set; }
}
