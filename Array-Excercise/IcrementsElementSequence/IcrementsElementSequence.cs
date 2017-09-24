using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int startIndex = 0;
        int lenght = 1;
        int maxStartIndex = 0;
        int maxLenght = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                lenght++;
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    maxStartIndex = startIndex;
                }
            }
            else
            {
                startIndex = i;
                lenght = 1;
            }
        }
        for (int i = maxStartIndex; i < maxStartIndex + maxLenght; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

