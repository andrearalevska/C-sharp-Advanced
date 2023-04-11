
namespace Task1.Domain.Models
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public Shape(int id)
        {
            if (id < 0)
            {
                Console.WriteLine("ERROR! Invalid input for number.");
            }
            Id = id;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter(); 

    }
}
