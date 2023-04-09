
using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class CarWash : ICarWash
    {
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
