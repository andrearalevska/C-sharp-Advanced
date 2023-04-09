
using Homework2.Domain.Models;

namespace Homework2.Domain.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle(Vehicle vehicle);
        void FixVehicle(Vehicle vehicle);
    }
}
