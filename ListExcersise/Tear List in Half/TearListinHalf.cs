using System;
using System.Collections.Generic;
using System.Linq;

class TearListinHalf
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> firstPart = new List<int>();
        for (int i = 0; i <numbers.Count / 2; i++)
        {
            firstPart.Add(numbers[i]);
        }
        for (int i = 0; i < firstPart.Count; i++)
        {
            numbers.Remove(numbers[0]);
        }
        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            var firstElement = numbers[i];
            var firstDigit = firstElement / 10;
            var lastDigit = firstElement % 10;
            result.Add(firstDigit);
            result.Add(firstPart[i]);
            result.Add(lastDigit);
            

        }
        Console.WriteLine(string.Join(" " , result));
    }
}

