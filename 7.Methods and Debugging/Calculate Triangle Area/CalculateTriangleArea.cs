using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        var result = GetArea(width, height);
        Console.WriteLine(result);
    }
    static double GetArea(double width, double height)
    {
        return width * height / 2;
    }
}

