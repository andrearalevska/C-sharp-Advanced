
using Task1.Domain.Models;

namespace Task1.Domain
{
    public class ShapeDB<T> where T : Shape
    {
        public List<T> Shapes { get; set; }

        public ShapeDB()
        {
            Shapes = new List<T>();
        }
        public void AddShape(T shape)
        {
            Shapes.Add(shape);
        }

        public void PrintAllAreas()
        {
            Console.WriteLine("Shape areas:");
            foreach (T shape in Shapes) 
            {
                Console.WriteLine($"Shape with ID: {shape.Id} has an area of {shape.GetArea()}");
            }
        }

        public void PrintAllPerimeters()
        {
            Console.WriteLine("Shape perimeters:");
            foreach (T shape in Shapes)
            {
                Console.WriteLine($"Shape with ID: {shape.Id} has a perimeter of {shape.GetPerimeter()}");
            }
        }
    }
}
