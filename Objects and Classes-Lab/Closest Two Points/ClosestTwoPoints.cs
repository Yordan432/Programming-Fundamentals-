using System;
using System.Collections.Generic;
using System.Linq;

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
    public override string ToString()
    {
        return String.Format($"({X} , {Y})");
    }
}

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }


    public int CalcArea()
    {
        return Width * Height;
    }
}
class ClosestTwoPoints
{
    static void Main()
    {

        Rectangle rectangele = new Rectangle();
        Console.WriteLine(rectangele.CalcArea());
        return;

        List<Point> points = new List<Point>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Point currentPoint = Point.ReadPoint(Console.ReadLine());
            points.Add(currentPoint);
        }
        double minDistance = double.MaxValue;
        Point[] closetPoints =new Point[2];
        for (int prevPoint = 0; prevPoint < points.Count; prevPoint++)
        {
            for (int nextPoint = prevPoint + 1; nextPoint < points.Count; nextPoint++)
            {
                double distance = CalcDistance(points[prevPoint], points[nextPoint]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closetPoints[0] = points[prevPoint];
                    closetPoints[1] = points[nextPoint];
                }

            }
        }
        Console.WriteLine($"{minDistance:f3}");
        Console.WriteLine(closetPoints[0]);
        Console.WriteLine(closetPoints[1]);
    }
    private static double CalcDistance(Point point1, Point point2)
    {
        //Sqr.(x2 - x1)^2 + (y2 - y1)^2
        var sideX = Math.Pow((point1.X - point2.X), 2);
        var sideY = Math.Pow((point1.Y - point2.Y), 2);
        double sideSum = sideX + sideY;
        var sqr = Math.Sqrt(sideSum);

        return sqr;
    }
}

