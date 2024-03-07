using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square(3, "Yellow");
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(3, 6, "Blue");
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(3, "Red");
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}.");  
        }
        
        
        

        
    }
}