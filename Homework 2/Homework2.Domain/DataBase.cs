

using Homework2.Domain.Models;

namespace Homework2.Domain
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles { get; set; }

        static DataBase()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
