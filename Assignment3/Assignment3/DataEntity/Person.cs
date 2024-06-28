using Assignment3.Interfaces;

namespace Assignment3.DataEntity;

public abstract class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    private decimal salary;
    private List<string> _addresses = new List<string>();

    public Person(string name, DateTime dob, decimal salary)
    {
        Name = name;
        DateOfBirth = dob;
        Salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }

            salary = value;
        }
    }
    
    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }

    public void AddAddress(string address)
    {
        _addresses.Add(address);
    }
    
    public List<string> GetAddress()
    {
        return _addresses;
    }
}