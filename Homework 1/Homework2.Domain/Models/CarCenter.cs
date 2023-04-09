
using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking the {vehicle.Type} {vehicle.Brand}");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing the {vehicle.Type} {vehicle.Brand}");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas in the {vehicle.Type} {vehicle.Brand}");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing {car.Type} {car.Brand} in process..");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing trailer of {truck.Type} {truck.Brand} in process..");
        }
    }
}
