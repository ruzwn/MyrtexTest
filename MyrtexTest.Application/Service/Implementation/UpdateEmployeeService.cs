using Microsoft.AspNetCore.Mvc;
using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Service.Implementation;

public class UpdateEmployeeService : IService<UpdateEmployeeRequest, EmptyResult>
{
    private readonly IRepository<Employee> _employeeRepository;

    public UpdateEmployeeService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<EmptyResult> HandleAsync(UpdateEmployeeRequest request, CancellationToken cancellationToken)
    {
        Employee employee = await _employeeRepository.GetOneAsync(request.Id, cancellationToken);

        employee.Department = request.Department;
        employee.FullName = request.FullName;
        employee.BirthDate = request.BirthDate;
        employee.EmploymentDate = request.EmploymentDate;
        employee.Salary = request.Salary;

        await _employeeRepository.UpdateAsync(employee, cancellationToken);

        return new EmptyResult();
    }
}
