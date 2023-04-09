
using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public class Cat : Animal, ICat
    {
       public string FavouriteFood { get; set; }

       public Cat(string name, string color, int age, string favouritefood) : base(name, color, age)
        {
            if (string.IsNullOrEmpty(favouritefood))
            {
                Console.WriteLine("Invalid input for favourite food");
            }
            FavouriteFood = favouritefood;
        }

        public override void PrintAnimal()
        {
            Console.WriteLine("Cat info:");
            Console.WriteLine($"Name: {Name}, Color: {Color}, Age:{Age}, Favourite food: {FavouriteFood}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}");
        }
    }
}
