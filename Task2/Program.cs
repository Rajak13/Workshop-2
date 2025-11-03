public class Circle
{
    public const double PI = 3.14;

    public double GetArea(double rad)
    {
        return PI * rad * rad;
    }
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

        // Trying to modify PI in public class gives Error: The left-hand side of an assignment must be a variable, property or indexer
    }
}
