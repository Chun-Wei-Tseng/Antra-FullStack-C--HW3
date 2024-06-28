namespace Assignment3.Interfaces;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddress();
}