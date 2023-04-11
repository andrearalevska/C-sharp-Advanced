
namespace Task1.Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int id, double radius) : base(id) 
        {
            if (radius < 0)
            {
                Console.WriteLine("Error. Invalid input for radius.");
            }
            Radius= radius;
        }

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
