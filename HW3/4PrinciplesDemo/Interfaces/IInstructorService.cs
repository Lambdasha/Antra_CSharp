using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Interfaces;

public interface IInstructorService : IPersonService
{
    int CalculateExperience();
    decimal CalculateBonus();
}