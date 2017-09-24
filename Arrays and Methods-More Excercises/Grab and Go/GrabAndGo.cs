using System;
using System.Collections.Generic;
using System.Linq;
class GrabAndGo
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        long sum = 0;

        if (!numbers.Contains(n))
        {
            Console.WriteLine("No occurrences were found!");
            return;
        }
        for (int i =numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] == n)
            {
                for (int j = 0;  j < numbers.Length - 1;  j++)
                {
                    if (j != i)
                    {
                        sum += numbers[j];
                    }
                    if (j >= i)
                    {
                        Console.WriteLine(sum);
                        return;
                    }
                }
            }
        }
       
    }
}

