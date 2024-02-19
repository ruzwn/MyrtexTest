using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyrtexTest.Application.Model.Request;

// todo: что такое record-ы ???
public record CreateEmployeeRequest(
    [BindRequired] string Department,
    [BindRequired] string FullName,
    [BindRequired] DateOnly BirthDate,
    [BindRequired] DateOnly EmploymentDate,
    [BindRequired] decimal Salary);
