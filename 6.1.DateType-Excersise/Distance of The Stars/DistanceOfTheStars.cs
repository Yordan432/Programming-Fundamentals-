using System;

class DistanceOfTheStars
{
    static void Main()
    {
        decimal earthNearestStar = 4.22M * 9450000000000;
        decimal centerofourgalaxy = 26000M * 9450000000000;
        decimal MilkyWay = 100000M * 9450000000000;
        decimal distanceEarth = 46500000000M * 9450000000000;

        Console.WriteLine(earthNearestStar.ToString("e2"));
        Console.WriteLine(centerofourgalaxy.ToString("e2"));
        Console.WriteLine(MilkyWay.ToString("e2"));
        Console.WriteLine(distanceEarth.ToString("e2"));

    }
}

