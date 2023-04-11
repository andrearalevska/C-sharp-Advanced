
using Task2.Domain.Enums;

namespace Task2.Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Age { get; set; }

        public Pet (string name, PetType type, int age)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("ERROR.Invalid input for name!");
            }
            Name = name;
            
            Type = type;
            
            if(age < 0)
            {
                Console.WriteLine("ERROR.Invalid input for age!");
            }
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
