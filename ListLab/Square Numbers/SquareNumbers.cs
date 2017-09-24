using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        List<double> square = new List<double>();

        foreach (var element in numbers)
        {
            if (Math.Sqrt(element) == (int)Math.Sqrt(element))
            {
                square.Add(element);
            }
        }
        square.Sort((a , b ) => b.CompareTo(a));
        Console.WriteLine(string.Join(" " , square));
    }
}

