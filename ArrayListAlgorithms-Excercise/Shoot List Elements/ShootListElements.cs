using System;
using System.Collections.Generic;
using System.Linq;
class ShootListElements
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<int> numbers = new List<int>();
        while (input != "stop")
        {
            if (input == "bang")
            {
                var average = FindAverageSumOfNumbers(numbers);
                FindSmallerNumberFromAverageAndRemove(numbers, average);
                DecrementAllNumbers(numbers);
            }
            else
            {
                AddLastInFirstPosition(input, numbers);
            }
            if (numbers.Count == 0)
            {
                return;
            }
            input = Console.ReadLine();
        }

        Console.WriteLine("survivors: " + string.Join(" ", numbers));
    }
    private static void DecrementAllNumbers(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i]--;
        }
    }
    private static void FindSmallerNumberFromAverageAndRemove(List<int> numbers, double average)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < average)
            {
                Console.WriteLine("shot {0}", numbers[i]);
                numbers.Remove(numbers[i]);
                break;
            }
            if (numbers.Count == 1)
            {
                Console.WriteLine("nobody left to shoot! last one was {0}", numbers[0]);
                numbers.Remove(numbers[0]);
                return;
            }
        }
    }
    static double FindAverageSumOfNumbers(List<int> numbers)
    {
        var average = numbers.Average();
        return average;
    }

    private static void AddLastInFirstPosition(string input, List<int> numbers)
    {
        var parseNumber = int.Parse(input);
        numbers.Insert(0, parseNumber);

    }
}


