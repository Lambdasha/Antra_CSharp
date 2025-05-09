using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Models;

public class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; }
    public Department Department { get; private set; }

    public Instructor(string firstName, string lastName, DateTime dob,
        decimal baseSalary, DateTime joinDate)
        : base(firstName, lastName, dob, baseSalary)
    {
        JoinDate = joinDate;
    }

    public int CalculateExperience()
    {
        var today = DateTime.Today;
        int exp = today.Year - JoinDate.Year;
        if (JoinDate.Date > today.AddYears(-exp)) exp--;
        return exp;
    }

    public decimal CalculateBonus() => 500m * CalculateExperience();

    public override decimal CalculateSalary() => base.CalculateSalary() + CalculateBonus();

    public void AssignDepartment(Department dept, bool isHead = false)
    {
        Department = dept;
        if (isHead)
            dept.SetHead(this);
    }
}
