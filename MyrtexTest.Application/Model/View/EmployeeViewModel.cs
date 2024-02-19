using MyrtexTest.Domain.Model;

namespace MyrtexTest.Application.Model.View;

public class EmployeeViewModel
{
    public Guid Id { get; set; }
    
    public string Department { get; set; }

    public string FullName { get; set; }

    public DateOnly BirthDate { get; set; }

    public DateOnly EmploymentDate { get; set; }

    public decimal Salary { get; set; }

    public static EmployeeViewModel FromDomain(Employee employee)
    {
        var result = new EmployeeViewModel
        {
            Id = employee.Id,
            Department = employee.Department,
            FullName = employee.FullName,
            BirthDate = employee.BirthDate,
            EmploymentDate = employee.EmploymentDate,
            Salary = employee.Salary
        };

        return result;
    }
}
