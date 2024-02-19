using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyrtexTest.Application.Model.Request;

public record UpdateEmployeeRequest(
    [BindRequired] Guid Id,
    [BindRequired] string Department,
    [BindRequired] string FullName,
    [BindRequired] DateOnly BirthDate,
    [BindRequired] DateOnly EmploymentDate,
    [BindRequired] decimal Salary);
