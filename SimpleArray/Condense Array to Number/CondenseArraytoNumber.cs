using System;
using System.Collections.Generic;
using System.Linq;

class CondenseArraytoNumber
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i =numbers.Count - 1; i > 0; i--)
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                if (j + 1 < numbers.Count)
                {
                    numbers[j] += numbers[j + 1];
                }
                else
                {
                    numbers.RemoveRange(numbers.Count - 1, 1);
                }
            }
        }
        Console.WriteLine(numbers[0]);
    }
}

