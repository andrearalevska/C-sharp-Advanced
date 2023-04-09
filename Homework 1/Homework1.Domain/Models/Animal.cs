using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public Animal(string name, string color, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name");
                return;
            }
            Name = name;
            if(string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color");
                return;
            }
            Color = color;
            if( age < 0)
            {
                Console.WriteLine("Invalid input for age");
                return;
            }
            Age = age;
          
        }

        public abstract void PrintAnimal();
    }
}
