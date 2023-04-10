
namespace Homework2.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike() { }

        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color.");
            }
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine("Information for bike:");
            Console.WriteLine($"Year of production: {YearOfProduction}, Color: {Color}");
        }
    }
}
