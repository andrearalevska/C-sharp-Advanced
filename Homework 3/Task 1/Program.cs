using Task1.Domain;
using Task1.Domain.Models;

ShapeDB<Shape> shapeDb = new ShapeDB<Shape>();

Circle circle = new Circle(1, 5);
Rectangle rectangle = new Rectangle(4, 15, 3);
Circle secondCircle = new Circle(6, 10);
Rectangle secondRectangle = new Rectangle(7, 2, 5);

circle.CircleInfo();
rectangle.RectangleInfo();

shapeDb.AddShape(circle);
shapeDb.AddShape(rectangle);
shapeDb.AddShape(secondCircle);
shapeDb.AddShape(secondRectangle);

shapeDb.PrintAllPerimeters();
shapeDb.PrintAllAreas();


