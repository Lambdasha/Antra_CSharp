using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Models;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> _grades = new Dictionary<Course, char>();

    public Student(string firstName, string lastName, DateTime dob)
        : base(firstName, lastName, dob, 0m) { }

    public void EnrollCourse(Course course, char grade)
    {
        if (grade < 'A' || grade > 'F') throw new ArgumentException("Invalid grade");
        _grades[course] = grade;
        course.EnrollStudent(this, grade);
    }

    public IEnumerable<Course> GetCourses() => _grades.Keys.ToList().AsReadOnly();

    public double CalculateGpa()
    {
        if (_grades.Count == 0) return 0.0;
        double total = 0;
        foreach (var grade in _grades.Values)
        {
            total += grade switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                _   => 0.0
            };
        }
        return total / _grades.Count;
    }

    public override decimal CalculateSalary() => 0m;
}
