using System.ComponentModel.DataAnnotations;

namespace MyrtexTest.Application.Model.Request;

public record UpdateEmployeeRequest(
    [Required] Guid Id,
    [Required] string Department,
    [Required] string FullName,
    [Required] DateOnly BirthDate,
    [Required] DateOnly EmploymentDate,
    [Required] decimal Salary);
