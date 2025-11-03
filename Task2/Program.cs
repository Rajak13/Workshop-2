using System;

public class Circle
{
    // Constant PI
    public const double PI = 3.14;

    // Method to calculate area
    public double GetArea(double rad)
    {
        return PI * rad * rad;
    }

    // Method to calculate perimeter
    public double GetPerimeter(double rad)
    {
        return 2 * PI * rad;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        double radius = 5;

        Console.WriteLine("Area: " + circle.GetArea(radius));
        Console.WriteLine("Perimeter: " + circle.GetPerimeter(radius));

        // Trying to modify PI (uncomment to see compilation error)
        // Circle.PI = 3.14159; // Error: The left-hand side of an assignment must be a variable, property or indexer
    }
}
