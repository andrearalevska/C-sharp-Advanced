
using Homework2.Domain.Models;

namespace Homework2.Domain.Interfaces
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
