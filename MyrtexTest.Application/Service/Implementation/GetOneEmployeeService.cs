using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Model.View;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Service.Implementation;

public class GetOneEmployeeService : IService<GetOneEmployeeRequest, EmployeeViewModel>
{
    private readonly IRepository<Employee> _employeeRepository;

    public GetOneEmployeeService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<EmployeeViewModel> HandleAsync(GetOneEmployeeRequest request, CancellationToken cancellationToken)
    {
        Employee employee = await _employeeRepository.GetOneAsync(request.Id, cancellationToken);

        return EmployeeViewModel.FromDomain(employee);
    }
}
