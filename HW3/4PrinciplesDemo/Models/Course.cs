using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Models;

public class Course : ICourseService
{
    public string Name { get; }
    private List<Student> _students = new List<Student>();

    public Course(string name) => Name = name;

    public void EnrollStudent(Student student, char grade)
    {
        if (!_students.Contains(student))
            _students.Add(student);
    }

    public IEnumerable<Student> GetEnrolledStudents() => _students.AsReadOnly();
}