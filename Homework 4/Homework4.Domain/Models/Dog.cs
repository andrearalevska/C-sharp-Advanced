
namespace Homework4.Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }   

        public Dog(string name, int age, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name!");
            }
            Name = name;
            
            if(age < 0)
            {
                Console.WriteLine("Invalid input for age!");
            }
            Age = age;

            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color!");
            }
            Color = color;
        }
    }
}
