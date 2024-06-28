using Assignment3.Interfaces;

namespace Assignment3.DataEntity;

public class Student : Person, IStudentService
{
    private List<Course> courses = new List<Course>();
    public Student(string name, DateTime dob, decimal salary) : base(name, dob, salary)
    {
    }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.EnrollStudent(this);
    }

    public double CalculateGpa()
    {
        if (courses.Count == 0) return 0;

        double totalPoints = courses.Sum(course => course.GetGradePoint(this));
        return totalPoints / courses.Count;
    }
}