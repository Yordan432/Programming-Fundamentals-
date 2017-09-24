using System;
using System.Collections.Generic;
using System.Linq;

class LargestNElement
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        Array.Reverse(numbers);

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = numbers[i];
        }
        
        Console.WriteLine(string.Join(" " , result));
    }
}

