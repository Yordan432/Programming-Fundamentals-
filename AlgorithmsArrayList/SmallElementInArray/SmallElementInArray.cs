using System;
using System.Linq;
using System.Collections.Generic;
class SmallElementInArray
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        Console.WriteLine(min);
    }
}

