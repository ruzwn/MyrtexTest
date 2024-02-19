using MyrtexTest.Application.Model.Common;
using MyrtexTest.Application.Model.View;
using MyrtexTest.Application.Repository.Common;
using MyrtexTest.Application.Service.Common;
using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Service.Implementation;

public class GetAllEmployeesService : IService<EmptyRequest, IList<EmployeeViewModel>>
{
    private readonly IRepository<Employee> _employeeRepository;

    public GetAllEmployeesService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IList<EmployeeViewModel>> HandleAsync(EmptyRequest request, CancellationToken cancellationToken)
    {
        IList<Employee> allEmployees = await _employeeRepository.GetAllAsync(cancellationToken);

        List<EmployeeViewModel> allEmployeesVm = allEmployees.Select(EmployeeViewModel.FromDomain).ToList();

        return allEmployeesVm;
    }
}
