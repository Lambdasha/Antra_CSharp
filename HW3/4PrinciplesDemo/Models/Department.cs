using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

namespace _4PrinciplesDemo.Models;

public class Department : IDepartmentService
{
    public string Name { get; }
    public Instructor Head { get; private set; }
    public decimal Budget { get; }
    public DateTime BudgetStart { get; }
    public DateTime BudgetEnd { get; }

    private List<Course> _courses = new List<Course>();

    public Department(string name, decimal budget, DateTime start, DateTime end)
    {
        Name = name; Budget = budget; BudgetStart = start; BudgetEnd = end;
    }

    public void SetHead(Instructor instructor) => Head = instructor;
    public void AddCourse(Course course) => _courses.Add(course);
    public IEnumerable<Course> GetCourses() => _courses.AsReadOnly();
}
