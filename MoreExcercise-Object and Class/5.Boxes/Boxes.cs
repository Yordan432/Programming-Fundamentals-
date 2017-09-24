using System;
using System.Collections.Generic;
using System.Linq;
class Box
{
    public int Rectangular { get; set; }

    public Point UpperLeft { get; set; }

    public Point UpperRight { get; set; }

    public Point BottomLeft { get; set; }

    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return 2 * width + 2 * height;
    }
    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
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
    public static int CalcDistance(Point point1, Point point2)
    {
        var sideX = Math.Pow((point1.X - point2.X), 2);
        var sideY = Math.Pow((point1.Y - point2.Y), 2);
        double sideSum = sideX + sideY;
        var sqr = Math.Sqrt(sideSum);

        return (int)sqr;
    }
}
class Boxes
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        List<Box> boxs = new List<Box>();
        while (input != "end")
        {
            var tokens = input.Split('|');

            var upperLeft = tokens[0].Trim().Split(':').Select(int.Parse).ToList();
            var upperRight = tokens[1].Trim().Split(':').Select(int.Parse).ToList();
            var bottomLeft = tokens[2].Trim().Split(':').Select(int.Parse).ToList();
            var bottomRight = tokens[3].Trim().Split(':').Select(int.Parse).ToList();

            Point upperLeftResult = new Point(upperLeft[0], upperLeft[1]);
            Point upperRightResult = new Point(upperRight[0], upperRight[1]);
            Point bottomLeftResult = new Point(bottomLeft[0], bottomLeft[1]);
            Point bottomRightResult = new Point(bottomRight[0], bottomRight[1]);

            Box box = new Box
            {
                UpperLeft = upperLeftResult,
                UpperRight = upperRightResult,
                BottomLeft = bottomLeftResult,
                BottomRight = bottomRightResult
            };
            boxs.Add(box);

            input = Console.ReadLine();
        }

        foreach (var box in boxs)
        {
            var widht = Point.CalcDistance(box.UpperLeft, box.UpperRight);
            var height = Point.CalcDistance(box.UpperLeft, box.BottomLeft);
            int perimeter = Box.CalculatePerimeter(widht, height);
            int area = Box.CalculateArea(widht, height);

            Console.WriteLine($"Box: {widht}, {height}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
        }
    }
}

