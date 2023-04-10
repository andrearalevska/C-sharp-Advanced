
namespace Homework2.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesOfProduction { get; set; }

        public Car()
        {
            CountriesOfProduction = new List<string>();
        }
        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countriesOfProduction) : base(id,type, yearOfProduction, batchNumber)
        {
            if(fuelTank < 0 || fuelTank == null)
            {
                Console.WriteLine("Invalid input for fuelTank");
            }
            FuelTank = fuelTank;
            CountriesOfProduction = countriesOfProduction;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine("Information for car:");
            Console.WriteLine($"Vehicle type: {Type}");
            Console.WriteLine("Countries of production:");
            foreach(var country in CountriesOfProduction)
            {
                Console.WriteLine($"{country}");
            }
        }


    }
}
