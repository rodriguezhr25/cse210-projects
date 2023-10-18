using System;

class Program
{
    static void Main(string[] args)
    {
               // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Create a square, rectangle, and circle and add it to this list.
        shapes.Add(new Square("Purple", 2));
        shapes.Add(new Rectangle("Black", 2, 6));
        shapes.Add(new Circle("Yellow", 3));

        // Get a custom calculation for each one
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color:  {shape.GetColor()}");
            Console.WriteLine($"Area:  {shape.GetArea()}");
            Console.WriteLine("");
        }
    }
}