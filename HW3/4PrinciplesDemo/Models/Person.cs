using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Models;

public abstract class Person : IPersonService
{
    public string FirstName { get; }
    public string LastName { get; }
    public DateTime DateOfBirth { get; }
    protected decimal SalaryBacking;

    private List<Address> _addresses = new List<Address>();

    protected Person(string firstName, string lastName, DateTime dob, decimal salary)
    {
        if (salary < 0) throw new ArgumentException("Salary cannot be negative");
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
        SalaryBacking = salary;
    }

    public int CalculateAge()
    {
        var today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public virtual decimal CalculateSalary() => SalaryBacking;

    public void AddAddress(Address address) => _addresses.Add(address);

    public IEnumerable<Address> GetAddresses() => _addresses.AsReadOnly();
}