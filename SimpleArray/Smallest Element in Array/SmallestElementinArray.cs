using System;
using System.Linq;

class SmallestElementinArray
{
    static void Main()
    {
        var arrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var minNumber = int.MaxValue;

        foreach (var number in arrayNumbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }
        }
        Console.WriteLine(minNumber);
       
    }
}

