
using Task2.Domain.Enums;

namespace Task2.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Fish(string name, PetType type, int age, string color, string size) : base(name, type, age)
        {
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Error. Invalid input for color");
            }
            Color = color;

            if (string.IsNullOrEmpty(size))
            {
                Console.WriteLine("Error. Invalid input for size");
            }
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Information for {Type} {Name}: \n Age: {Age} \n Color: {Color} \n Size: {Size}");
        }
    }
}
