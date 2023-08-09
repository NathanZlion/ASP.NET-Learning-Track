
using System;

public class Program
{

    public static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"Shape Name : {shape.Name}");
        Console.WriteLine($"Shape Area :{shape.CalculateArea()}");
    }
    public static void Main(String[] args)
    {
        Shape circle = new Circle("Circle") { Radius = 10 };
        PrintShapeArea(circle);

        Shape rectangle = new Rectangle("Rectangle") { Height = 10, Width = 5 };
        PrintShapeArea(rectangle);

        Shape triangle = new Triangle("Triangle") { Height = 10, Base = 5 };
        PrintShapeArea(triangle);
    }
}

public abstract class Shape
{
    public string Name;

    public Shape(string name) => Name = name;
    public abstract double CalculateArea();

}

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(string name) : base(name) { }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string name) : base(name) { }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public Triangle(string name) : base(name) { }

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}

