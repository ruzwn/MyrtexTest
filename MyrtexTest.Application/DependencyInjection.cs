using Microsoft.Extensions.DependencyInjection;
using MyrtexTest.Application.Model.Common;
using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Model.View;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Application.Service.Implementation;
using EmptyResult = Microsoft.AspNetCore.Mvc.EmptyResult;

namespace MyrtexTest.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddServices();
    }

    private static void AddServices(this IServiceCollection services)
    {
        // todo: add services from assembly? (use scrutor ???)
        // todo: transient, scoped or singleton ???
        services.AddScoped<IService<GetOneEmployeeRequest, EmployeeViewModel>, GetOneEmployeeService>();
        services.AddScoped<IService<EmptyRequest, IList<EmployeeViewModel>>, GetAllEmployeesService>();
        services.AddScoped<IService<CreateEmployeeRequest, Guid>, CreateEmployeeService>();
        services.AddScoped<IService<UpdateEmployeeRequest, EmptyResult>, UpdateEmployeeService>();
        services.AddScoped<IService<DeleteEmployeeRequest, EmptyResult>, DeleteEmployeeService>();
    }
}
