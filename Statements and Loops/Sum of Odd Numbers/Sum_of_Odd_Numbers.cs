using System;
using System.Collections.Generic;
using System.Linq;

class Sum_of_Odd_Numbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        var sum = 0;
        var allOddNumberToList = new List<int>();
        for (int i = 1; i <=number; i++)
        {
            if (number % 2 != 0)
            {
                sum = sum + number;             
            }                  
        }
        for (int c = 0; c <sum; c++)
        {
            if (c % 2 != 0)
            {
                Console.WriteLine(c);
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }
}

