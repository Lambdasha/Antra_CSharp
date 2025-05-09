// See https://aka.ms/new-console-template for more information

using _4PrinciplesDemo.Models;
using _4PrinciplesDemo.Interfaces;

var dept = new Department("Computer Science", 1000000m, DateTime.Today, DateTime.Today.AddYears(1));
var instr = new Instructor("Alice", "Smith", new DateTime(1980,1,1), 50000m, new DateTime(2020,9,1));
instr.AddAddress(new Address("123 Main St", "Los Angeles", "Country"));
instr.AssignDepartment(dept, isHead: true);

Console.WriteLine($"{instr.FirstName} {instr.LastName}, Age: {instr.CalculateAge()}, Salary: {instr.CalculateSalary():C}, Experience: {instr.CalculateExperience()} years");
Console.WriteLine($"Department Head: {instr.Department.Name}");
Console.WriteLine("Addresses: " + string.Join("; ", instr.GetAddresses()));

var student = new Student("Bob", "Jones", new DateTime(2000,5,15));
student.AddAddress(new Address("1 LMU Drive", "University Town", "Country"));
var cs101 = new Course("CS101");
student.EnrollCourse(cs101, 'A');
student.EnrollCourse(cs101, 'B');

Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.CalculateAge()}, GPA: {student.CalculateGpa():F2}");
Console.WriteLine("Courses: " + string.Join(", ", student.GetCourses().Select(c => c.Name)));
