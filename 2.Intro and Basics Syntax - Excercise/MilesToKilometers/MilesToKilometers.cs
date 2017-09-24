using System;

class MilesToKilometers
{
    static void Main()
    {
        var miles = double.Parse(Console.ReadLine());
        var killometers = miles * 1.60934;
        Console.WriteLine($"{killometers:f2}");
    }
}

