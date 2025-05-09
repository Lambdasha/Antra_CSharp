using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Interfaces;

public interface IDepartmentService
{
    void AddCourse(Course course);
    IEnumerable<Course> GetCourses();
    void SetHead(Instructor instructor);
}
