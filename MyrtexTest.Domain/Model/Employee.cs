using MyrtexTest.Domain.Model.Common;

namespace MyrtexTest.Domain.Model;

public class Employee : BaseDomainModel
{
    public string Department { get; set; } // todo: отдельный класс сделать ???

    public string FullName { get; set; } // todo: отдельный класс сделать ???

    public DateOnly BirthDate { get; set; }

    public DateOnly EmploymentDate { get; set; }

    private decimal _salary;

    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
            {
                throw new Exception(); // todo: redo
            }

            _salary = value;
        }
    }

    // todo: ctor for ORM?

    private Employee(
        string department,
        string fullName,
        DateOnly birthDate,
        DateOnly employmentDate,
        decimal salary)
    {
        Department = department;
        FullName = fullName;
        BirthDate = birthDate;
        EmploymentDate = employmentDate;
        Salary = salary;
    }

    public static Employee Create(
        string department,
        string fullName,
        DateOnly birthDate,
        DateOnly employmentDate,
        decimal salary)
    {
        var result = new Employee(
            department,
            fullName,
            birthDate,
            employmentDate,
            salary);

        return result;
    }
}
