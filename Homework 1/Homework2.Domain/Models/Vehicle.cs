
using Homework2.Domain.Enums;

namespace Homework2.Domain.Models
{
    public abstract class Vehicle
    {
        public VehicleType Type { get; set; }
        public string Brand { get; set; }

        public Vehicle(VehicleType type, string brand)
        {
            Type = type;
            
            if(string.IsNullOrEmpty(brand)) 
            {
                Console.WriteLine("Invalid input for brand");
            }
            Brand = brand;

        }

        public abstract void Drive();
    }
}
