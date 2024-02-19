using Microsoft.AspNetCore.Mvc;
using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Service.Implementation;

public class DeleteEmployeeService : IService<DeleteEmployeeRequest, EmptyResult>
{
    private readonly IRepository<Employee> _employeeRepository;

    public DeleteEmployeeService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<EmptyResult> HandleAsync(DeleteEmployeeRequest request, CancellationToken cancellationToken)
    {
        await _employeeRepository.DeleteAsync(request.Id, cancellationToken);

        return new EmptyResult();
    }
}
