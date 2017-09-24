using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesandReverse
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> result = new List<int>();

        int lenght = numbers.Count;

        bool[] isNegativeNumbers = new bool[numbers.Count];
        int index = 0;
        while (numbers[index] < 0)
        {
            isNegativeNumbers[index] = true;
            index++;
            if (index >= numbers.Count - 1)
            {
                Console.WriteLine("empty");
                return;
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0)
            {
                result.Add(numbers[i]);
            }
        }
        result.Reverse();
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}

