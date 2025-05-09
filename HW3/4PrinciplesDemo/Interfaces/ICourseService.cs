using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Interfaces;

public interface ICourseService
{
    void EnrollStudent(Student student, char grade);
    IEnumerable<Student> GetEnrolledStudents();
}
