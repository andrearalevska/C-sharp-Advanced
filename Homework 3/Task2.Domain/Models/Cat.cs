
using Task2.Domain.Enums;

namespace Task2.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, PetType type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            
            if (livesLeft < 0)
            {
                Console.WriteLine("Error. Invalid input for lives left.");
            }
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information for {Type} {Name}: \n Age: {Age} \n Lazy: {Lazy} \n Lives left: {LivesLeft}");
        }
    }
}
