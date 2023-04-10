
using Homework2.Domain.Models;

namespace Homework2.Domain.Helpers
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id <= 0)
            {
                Console.WriteLine($"Error.Invalid input for id in vehicle {vehicle.Type}");
            }
            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Error.Invalid input for type for this vehicle");
            }
            if (vehicle.YearOfProduction <= 0)
            {
                Console.WriteLine($"Error.Invalid input for year of production in vehicle {vehicle.Type}");
            }
        }
    }
}
