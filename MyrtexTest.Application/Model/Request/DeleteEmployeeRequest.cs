using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyrtexTest.Application.Model.Request;

public record DeleteEmployeeRequest([BindRequired] Guid Id);
