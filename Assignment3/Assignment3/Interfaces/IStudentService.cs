using Assignment3.DataEntity;

namespace Assignment3.Interfaces;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGpa();
}