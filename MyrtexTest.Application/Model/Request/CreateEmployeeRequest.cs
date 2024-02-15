namespace MyrtexTest.Application.Model.Request;

// todo: что такое record-ы ???
public record CreateEmployeeRequest(
    string Department,
    string FullName,
    DateOnly BirthDate,
    DateOnly EmploymentDate,
    decimal Salary);
