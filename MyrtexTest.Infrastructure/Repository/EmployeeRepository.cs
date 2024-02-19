using Microsoft.EntityFrameworkCore;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Domain.Model;
using MyrtexTest.Infrastructure.Database;

namespace MyrtexTest.Infrastructure.Repository;

public class EmployeeRepository : IRepository<Employee>
{
    private readonly MyrtexDbContext _dbContext;
    private DbSet<Employee> Employees => _dbContext.Employees;

    public EmployeeRepository(MyrtexDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Employee> GetOneAsync(Guid id, CancellationToken cancellationToken)
    {
        // todo: First or Single? "==" or Equals?
        Employee? result = await Employees.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        if (result is null)
        {
            throw new Exception(); // todo:
        }

        return result;
    }

    public async Task<IList<Employee>> GetManyAsync(ICollection<Guid> ids, CancellationToken cancellationToken)
    {
        // todo: what is .ToLookup? return Dictionary<Guid, Employee> ??? 
        List<Employee> result = await Employees
            .Where(x => ids.Contains(x.Id))
            .ToListAsync(cancellationToken);

        return result;
    }

    public async Task<IList<Employee>> GetAllAsync(CancellationToken cancellationToken)
    {
        List<Employee> result = await Employees.ToListAsync(cancellationToken);

        return result;
    }

    public async Task AddAsync(Employee entity, CancellationToken cancellationToken)
    {
        await Employees.AddAsync(entity, cancellationToken); // todo: or use "Add" (read AddAsync documentation)
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(Employee entity, CancellationToken cancellationToken)
    {
        Employees.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        // todo: First or Single? "==" or Equals?
        Employee? employee = await Employees.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        if (employee is null)
        {
            throw new Exception(); // todo:
        }

        Employees.Remove(employee);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
