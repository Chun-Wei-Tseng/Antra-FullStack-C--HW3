namespace Assignment3.DataEntity;

public class Course
{
    public string Name { get; set; }
    private Dictionary<Student, char> studentGrades = new Dictionary<Student, char>();

    public Course(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        if (!studentGrades.ContainsKey(student))
        {
            studentGrades[student] = 'F'; // Default grade
        }
    }

    public void AssignGrade(Student student, char grade)
    {
        if (studentGrades.ContainsKey(student))
        {
            studentGrades[student] = grade;
        }
    }

    public double GetGradePoint(Student student)
    {
        if (!studentGrades.ContainsKey(student))
            return 0;

        char grade = studentGrades[student];
        return grade switch
        {
            'A' => 4.0,
            'B' => 3.0,
            'C' => 2.0,
            'D' => 1.0,
            'F' => 0.0,
            _ => 0.0,
        };
    }
}