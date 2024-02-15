using System.ComponentModel.DataAnnotations;

namespace MyrtexTest.Application.Model.Request;

public record DeleteEmployeeRequest([Required] Guid Id);
