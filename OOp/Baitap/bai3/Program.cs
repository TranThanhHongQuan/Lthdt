public abstract class Shape
{
    public const double PI = 3.14159;
    public abstract double GetPerimeter();
    public abstract double GetArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetPerimeter()
    {
        return 2 * PI * Radius;
    }

    public override double GetArea()
    {
        return PI * Radius * Radius;
    }
}
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}
class TestShape
{
    static void Main(string[] args)
    {
        // Test Circle
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);

        Console.WriteLine($"Circle - Perimeter: {circle.GetPerimeter():F2}, Area: {circle.GetArea():F2}");

        // Test Rectangle
        Console.Write("Enter width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

        Console.WriteLine($"Rectangle - Perimeter: {rectangle.GetPerimeter():F2}, Area: {rectangle.GetArea():F2}");
    }
}

