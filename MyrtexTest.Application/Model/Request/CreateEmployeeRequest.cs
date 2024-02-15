using System.ComponentModel.DataAnnotations;

namespace MyrtexTest.Application.Model.Request;

// todo: что такое record-ы ???
public record CreateEmployeeRequest(
    [Required] string Department,
    [Required] string FullName,
    [Required] DateOnly BirthDate,
    [Required] DateOnly EmploymentDate,
    [Required] decimal Salary);
