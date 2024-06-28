namespace Assignment3.Interfaces;

public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
}