using System;
using ConsoleApp6;

class Program
{
    static void Main()
    {
        Figure circle = new Circle(5);
        Console.WriteLine($"Площадь круга: {circle.GetArea()}");

        Figure triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
        Console.WriteLine($"Прямоугольный треугольник: {((Triangle)triangle).IsRightTriangle()}");
    }
}
