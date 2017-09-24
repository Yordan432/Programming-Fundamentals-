using System;
using System.Collections.Generic;
using System.Linq;

class RoundingNumbersAwayZero
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        foreach (var num in numbers)
        {
            var rounded = Math.Round(num , MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {rounded}");
        }
    }
}

