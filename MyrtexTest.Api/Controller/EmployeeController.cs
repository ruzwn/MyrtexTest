using Microsoft.AspNetCore.Mvc;
using MyrtexTest.Application.Model.Request;
using MyrtexTest.Application.Service.Common;

namespace MyrtexTest.Api.Controller;

public class EmployeeController : BaseController
{
    public async Task<IActionResult> GetOneAsync(GetOneEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok();
    }

    // todo: зачем async делать и возвращать IActionResult или что-то другое ???
    [HttpPost] // todo: нужно ли писать Create и прочее или метод должен определяться типом http запроса
    // todo: что возвращать? что такое Ok?
    public async Task<IActionResult> CreateAsync(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        var service = GetService<IService<CreateEmployeeRequest, Guid>>();
        Guid employeeId = await service.HandleAsync(request, cancellationToken);

        return CreatedAtAction("GetOne", "Employee", new { id = employeeId }, null);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(UpdateEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(DeleteEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok();
    }
}
