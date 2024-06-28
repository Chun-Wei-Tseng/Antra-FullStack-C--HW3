using Assignment3.Interfaces;

namespace Assignment3.DataEntity;

public class Instructor : Person, IInstructorService
{
    private IInstructorService _instructorServiceImplementation;
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
    
    public Instructor(string name, DateTime dob, decimal salary, DateTime joinDate) : base(name, dob, salary)
    {
        JoinDate = joinDate;
    }

    public void AssignDepartment(Department department)
    {
        Department = department;
        department.Head = this;
    }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        return base.CalculateSalary() + (yearsOfExperience * 1000);
    }
}