﻿using System;
using System.Linq;

class ElementsEqualIndex
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int index = 0;
        for (int i = 0; i < numbers.Length ; i++)
        {
            if (numbers[i] == index)
            {
                Console.Write(numbers[i] + " ");
            }
            index++;
        }
        Console.WriteLine();
    }
}

