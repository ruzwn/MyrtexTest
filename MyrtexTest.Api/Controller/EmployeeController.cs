using Microsoft.AspNetCore.Mvc;
using MyrtexTest.Application.Model.Request;

namespace MyrtexTest.Api.Controller;

public class EmployeeController : BaseController
{
    // todo: зачем async делать и возвращать IActionResult или что-то другое ???
    [HttpPost("/Create")] // todo: нужно ли писать Create и прочее или метод должен определяться типом http запроса
    public async Task<IActionResult> CreateAsync(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok(); // todo: что возвращать? что такое Ok?
    }

    [HttpPut("/Update")]
    public async Task<IActionResult> UpdateAsync(UpdateEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpDelete("/Delete")]
    public async Task<IActionResult> DeleteAsync(DeleteEmployeeRequest request, CancellationToken cancellationToken)
    {
        return Ok();
    }
}
