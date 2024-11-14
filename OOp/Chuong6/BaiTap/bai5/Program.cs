using System;

abstract class Shape
{
    protected int x, y;

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        x += deltaX;
        y += deltaY;
    }

    public abstract void Show();

    public override abstract string ToString();
}

class Line : Shape
{
    private int x2, y2;

    public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
    }

    public override void Show()
    {
        Console.WriteLine($"Line from ({x}, {y}) to ({x2}, {y2})");
    }

    public override string ToString()
    {
        return $"Line: ({x}, {y}) to ({x2}, {y2})";
    }
}

class Circle : Shape
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public override void Show()
    {
        Console.WriteLine($"Circle at ({x}, {y}) with radius {radius}");
    }

    public override string ToString()
    {
        return $"Circle: Center=({x}, {y}), Radius={radius}";
    }
}

class Rectangle : Shape
{
    private int x2, y2, x3, y3;

    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public override void Show()
    {
        Console.WriteLine($"Rectangle with points ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})");
    }

    public override string ToString()
    {
        return $"Rectangle: Points=({x}, {y}), ({x2}, {y2}), ({x3}, {y3})";
    }
}

class PolyLine : Shape
{
    public PolyLine(int x, int y) : base(x, y)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"PolyLine starting at ({x}, {y})");
    }

    public override string ToString()
    {
        return $"PolyLine: Start=({x}, {y})";
    }
}
class Program
{
    static void Main()
    {
        Shape line = new Line(0, 0, 5, 5);
        Shape circle = new Circle(3, 3, 10);
        Shape rectangle = new Rectangle(1, 1, 4, 1, 1, 4);
        Shape polyline = new PolyLine(2, 2);

        line.Show();
        Console.WriteLine(line.ToString());

        circle.Show();
        Console.WriteLine(circle.ToString());

        rectangle.Show();
        Console.WriteLine(rectangle.ToString());

        polyline.Show();
        Console.WriteLine(polyline.ToString());
    }
}
