using System;
using System.Collections.Generic;
using System.Linq;

class ReverseArrayInplace
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count / 2; i++)
        {
            var firstElement = numbers[i];
            var lastElement = numbers[numbers.Count - i - 1];
            numbers[numbers.Count - i - 1] = firstElement;
            numbers[i] = lastElement;
        }
        Console.WriteLine(string.Join(" " , numbers));
    }
}

