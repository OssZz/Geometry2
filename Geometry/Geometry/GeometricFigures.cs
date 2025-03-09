namespace Geometry;

using System;
using System.Collections.Generic;

abstract class GeometricFigure
{
    public string Name { get; set; }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString() => $"{Name} -> Area: {GetArea():F5} | Perimeter: {GetPerimeter():F5}";
}

class Circle : GeometricFigure
{
    private double Radius;
    public Circle(string name, double radius) { Name = name; Radius = radius; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

class Square : GeometricFigure
{
    private double Side;
    public Square(string name, double side) { Name = name; Side = side; }
    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
}

class Rhombus : GeometricFigure
{
    private double D1, D2, Side;
    public Rhombus(string name, double d1, double d2, double side) { Name = name; D1 = d1; D2 = d2; Side = side; }
    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * Side;
}

class Kite : GeometricFigure
{
    private double D1, D2, A, B;
    public Kite(string name, double d1, double d2, double a, double b) { Name = name; D1 = d1; D2 = d2; A = a; B = b; }
    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (A + B);
}

class Rectangle : GeometricFigure
{
    private double A, B;
    public Rectangle(string name, double a, double b) { Name = name; A = a; B = b; }
    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);
}

class Parallelogram : GeometricFigure
{
    private double B, H, A;
    public Parallelogram(string name, double b, double h, double a) { Name = name; B = b; H = h; A = a; }
    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);
}

class Triangle : GeometricFigure
{
    private double B, H, A, C;
    public Triangle(string name, double b, double h, double a, double c) { Name = name; B = b; H = h; A = a; C = c; }
    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;
}

class Trapeze : GeometricFigure
{
    private double A, B, C, D, H;
    public Trapeze(string name, double a, double b, double c, double d, double h) { Name = name; A = a; B = b; C = c; D = d; H = h; }
    public override double GetArea() => ((A + D) * H) / 2;
    public override double GetPerimeter() => A + B + C + D;
}

class Program
{
    static void Main()
    {
        var figures = new List<GeometricFigure>
        {
            new Circle("Circle", 5),
            new Square("Square", 10),
            new Rhombus("Rhombus", 5, 7, 10),
            new Kite("Kite", 7, 6, 5, 8),
            new Rectangle("Rectangle", 4.568, 67.79),
            new Parallelogram("Parallelogram", 14.65, 54.67, 23.09),
            new Triangle("Triangle", 45.56, 12.34, 27.09, 15),
            new Trapeze("Trapeze", 10, 20, 30, 40, 20)
        };

        foreach (var figure in figures)
        {
            Console.WriteLine(figure);
        }
    }
}
