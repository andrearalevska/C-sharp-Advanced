
using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public string FavouriteToy { get; set; }

        public Dog(string name, string color, int age, string favouritetoy) : base(name, color, age) 
        {
            if (string.IsNullOrEmpty(favouritetoy))
            {
                Console.WriteLine("Invalid input for favourite toy.");
            }
            FavouriteToy = favouritetoy; 
        }
           
    public override void PrintAnimal()
        {
            Console.WriteLine("Dog info:");
            Console.WriteLine($"Name: {Name}, Color: {Color}, Age:{Age}, Favourite toy: {FavouriteToy}");
        }

        public void Bark()
        {
            Console.WriteLine("The dog is barking!");
        }
    }
}
