
using Homework2.Domain.Enums;
using System.Security.Cryptography.X509Certificates;

namespace Homework2.Domain.Models
{
    public class Truck : Vehicle
    {
        public Truck(VehicleType type, string brand) : base(type, brand) { }
        public override void Drive()
        {
            Console.WriteLine($"This truck of a brand {Brand} is in driving condition.");
        }
    }
}
