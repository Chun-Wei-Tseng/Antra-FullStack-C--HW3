namespace Assignment3.DataEntity;

public class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    private List<Course> courses = new List<Course>();

    public Department(string name, decimal budget, DateTime startDate, DateTime endDate)
    {
        Name = name;
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return courses;
    }
}