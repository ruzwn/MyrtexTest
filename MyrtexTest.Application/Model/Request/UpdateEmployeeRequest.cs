namespace MyrtexTest.Application.Model.Request;

public record UpdateEmployeeRequest(
    Guid Id,
    string Department,
    string FullName,
    DateOnly BirthDate,
    DateOnly EmploymentDate,
    decimal Salary);
