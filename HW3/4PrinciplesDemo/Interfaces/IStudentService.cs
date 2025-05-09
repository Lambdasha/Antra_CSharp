using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Interfaces;
public interface IStudentService : IPersonService
{
    double CalculateGpa();
    void EnrollCourse(Course course, char grade);
    IEnumerable<Course> GetCourses();
}