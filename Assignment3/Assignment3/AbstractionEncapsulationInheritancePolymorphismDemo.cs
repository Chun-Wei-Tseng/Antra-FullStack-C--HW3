namespace Assignment3;

public class AbstractionEncapsulationInheritancePolymorphismDemo
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        // Abstract method to be implemented by derived classes
        public abstract void DisplayInfo();
        public virtual void Honk()
        {
            Console.WriteLine("Honk Honk!");
        }
    }
    // Inheriting from Vehicle
    class Car : Vehicle
    {
        public string Color { get; set; }
        public Car(string brand, int year, string color) : base(brand, year)
        {
            Color = color;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This {Year} {Color} {Brand} Car");
        }
    }
    // Inheriting from Vehicle
    class Motorcycle : Vehicle
    {
        public string Model { get; set; }
        public Motorcycle(string brand, int year, string model) : base(brand, year)
        {
            Model = model;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This {Year} {Brand} {Model} Motorcycle");
        }
    }
    // Polymorphic function
    class Program
    {
        static void DisplayVehicleInfo(Vehicle vehicle)
        {
            vehicle.DisplayInfo();
        }
        static void Main()
        {
            Car car = new Car("Toyota", 2020, "Red");
            Motorcycle motorcycle = new Motorcycle("Harley Davidson", 2021, "Sportster");
            // Abstraction and Polymorphism
            Vehicle[] vehicles = { car, motorcycle };
            foreach (var vehicle in vehicles)
            {
                DisplayVehicleInfo(vehicle);
                vehicle.Honk(); // Polymorphic behavior
            }
        }
    }
}