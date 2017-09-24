using System;
using System.Collections.Generic;
using System.Linq;

public class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Amount { get; set; }
}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public static Point ReadPoint(string dateInput)
    {
        int[] date = dateInput.Split(' ').Select(int.Parse).ToArray();
        return new Point(date[0], date[1]);
    }
}
class DistancebetweenPoints
{
    static void Main()
    {
        Point firstPoint =Point.ReadPoint(Console.ReadLine());
        Point secondPoint = Point.ReadPoint(Console.ReadLine());

        double distance = CalcDistance(firstPoint , secondPoint);

        Console.WriteLine($"{distance:f3}");
    }

    private static double CalcDistance(Point point1, Point point2)
    {
        //Sqr.(x2 - x1)^2 + (y2 - y1)^2
        var sideX = Math.Pow((point1.X - point2.X) , 2);
        var sideY = Math.Pow((point1.Y - point2.Y) , 2);
        double sideSum = sideX + sideY;
        var sqr = Math.Sqrt(sideSum);

        return sqr;
    }
}

