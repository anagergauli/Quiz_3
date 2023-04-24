//Task_3, Quiz_3

//Ishape interface
//methods for calculating Area and perimeter
//prism, triangle, rectangle, and trapezium classes.
//Implementing IShape in each class.

using System;
using System.Collections.Generic;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Prism : IShape
{
    public double Height { get; set; }
    public IShape BaseShape { get; set; }

    public Prism(IShape baseShape, double height)
    {
        BaseShape = baseShape;
        Height = height;
    }

    public double CalculateArea()
    {
        return BaseShape.CalculatePerimeter() * Height + 2 * BaseShape.CalculateArea();
    }

    public double CalculatePerimeter()
    {
        return BaseShape.CalculatePerimeter() * 2 + 4 * Height;
    }
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double @base, double height, double side1, double side2, double side3)
    {
        Base = @base;
        Height = height;
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Trapezium : IShape
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public Trapezium(double base1, double base2, double height, double side1, double side2)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
        Side1 = side1;
        Side2 = side2;
    }

    public double CalculateArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }

    public double CalculatePerimeter()
    {
        return Base1 + Base2 + Side1 + Side2;
    }
}
