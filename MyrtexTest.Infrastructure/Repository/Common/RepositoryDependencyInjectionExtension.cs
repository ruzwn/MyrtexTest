using Microsoft.Extensions.DependencyInjection;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Infrastructure.Repository.Common;

public static class RepositoryDependencyInjectionExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        // todo: add repos from assembly?
        // todo: Transient, Scoped or Singleton for repository?
        services.AddTransient<IRepository<Employee>, EmployeeRepository>();
    }
}