using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Service.Implementation;

public class CreateEmployeeService : IService<CreateEmployeeRequest, Guid>
{
    private readonly IRepository<Employee> _employeeRepository;

    // todo: add log and validation?
    public CreateEmployeeService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Guid> HandleAsync(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        var employeeToAdd = Employee.Create(
            request.Department,
            request.FullName,
            request.BirthDate,
            request.EmploymentDate,
            request.Salary);
        await _employeeRepository.AddAsync(employeeToAdd, cancellationToken);

        return employeeToAdd.Id;
    }
}
