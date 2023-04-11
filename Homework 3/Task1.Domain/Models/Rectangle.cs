
namespace Task1.Domain.Models
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(int id, double sideA, double sideB) : base(id)
        {
            if(sideA < 0 || sideB < 0)
            {
                Console.WriteLine("Invalid input for length or width.");
            }
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return (2 * SideA) + (2 * SideB);
        }
    }
}
