using Microsoft.AspNetCore.Mvc;
using MyrtexTest.Application.Model.Common;
using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Model.View;
using MyrtexTest.Application.Service.Common;
using EmptyResult = Microsoft.AspNetCore.Mvc.EmptyResult;

namespace MyrtexTest.Api.Controller;

public class EmployeeController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetOneAsync([FromQuery] GetOneEmployeeRequest request, CancellationToken cancellationToken)
    {
        var service = GetService<IService<GetOneEmployeeRequest, EmployeeViewModel>>();
        EmployeeViewModel employee = await service.HandleAsync(request, cancellationToken);

        return Ok(employee);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        var service = GetService<IService<EmptyRequest, IList<EmployeeViewModel>>>();
        IList<EmployeeViewModel> allEmployees = await service.HandleAsync(new EmptyRequest(), cancellationToken);

        return Ok(allEmployees);
    }

    // todo: зачем async делать и возвращать IActionResult или что-то другое ???
    // todo: нужно ли писать Create и прочее или метод должен определяться типом http запроса
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        var service = GetService<IService<CreateEmployeeRequest, Guid>>();
        Guid employeeId = await service.HandleAsync(request, cancellationToken);

        return CreatedAtAction("GetOne", "Employee", new { id = employeeId }, null);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(UpdateEmployeeRequest request, CancellationToken cancellationToken)
    {
        var service = GetService<IService<UpdateEmployeeRequest, EmptyResult>>();
        await service.HandleAsync(request, cancellationToken);

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(DeleteEmployeeRequest request, CancellationToken cancellationToken)
    {
        var service = GetService<IService<DeleteEmployeeRequest, EmptyResult>>();
        await service.HandleAsync(request, cancellationToken);

        return Ok();
    }
}
