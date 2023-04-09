
using Homework2.Domain.Enums;

namespace Homework2.Domain.Models
{
    public class Car : Vehicle
    {
        public Car(VehicleType type, string brand) : base(type, brand) { }
        public override void Drive()
        {
            Console.WriteLine($"This car of a brand {Brand} is in driving condition.");
        }
    }
}
