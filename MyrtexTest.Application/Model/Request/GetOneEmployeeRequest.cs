using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyrtexTest.Application.Model.Request;

public record GetOneEmployeeRequest([BindRequired] Guid Id);
