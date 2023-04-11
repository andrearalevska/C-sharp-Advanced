
using Task2.Domain.Enums;

namespace Task2.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public Dog(string name, PetType type, int age, string favouriteFood) : base(name, type, age) 
        {
            if (string.IsNullOrWhiteSpace(favouriteFood))
            {
                Console.WriteLine("Error. Invalid input for favourite food!");
            }
            FavouriteFood = favouriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information for {Type} {Name}: \n Age: {Age} \n Favourite food: {FavouriteFood}");
        }
    }
}
