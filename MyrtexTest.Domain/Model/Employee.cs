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
}
