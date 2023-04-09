
using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking the {vehicle.Type} {vehicle.Brand}");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing the {vehicle.Type} {vehicle.Brand}");
        }
    }
}
