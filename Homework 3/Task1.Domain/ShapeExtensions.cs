
using Task1.Domain.Models;

namespace Task1.Domain
{
    public static class ShapeExtensions
    {
        public static void CircleInfo(this Circle circle)
        {
            Console.WriteLine($"Circle with radius {circle.Radius} has a perimeter of {circle.GetPerimeter()} and an area of {circle.GetArea()}.");
        }

        public static void RectangleInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with sides a: {rectangle.SideA} and b: {rectangle.SideB}, has a perimeter of {rectangle.GetPerimeter()} and an area of {rectangle.GetArea()}.");
        }
    }
}
