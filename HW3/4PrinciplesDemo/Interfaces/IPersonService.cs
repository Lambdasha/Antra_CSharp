using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Interfaces;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    IEnumerable<Address> GetAddresses();
}