
using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas in the {vehicle.Type} {vehicle.Brand}");
        }

    }
}
