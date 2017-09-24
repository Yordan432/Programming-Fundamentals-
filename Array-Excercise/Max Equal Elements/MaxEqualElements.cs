using System;
using System.Collections.Generic;
using System.Linq;
class MaxEqualElements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        int firstIndex = 0;
        int lenght = 1;
        int maxIndex = 0;
        int maxLenght = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i -1])
            {
                lenght++;
            }
            else
            {
                firstIndex = i;
                lenght = 1;

            }
            if (lenght > maxLenght)
            {
                maxLenght = lenght;
                maxIndex = i - lenght + 1;

            }
        }
        int[] result = numbers.Skip(maxIndex).Take(maxLenght).ToArray();
        Console.WriteLine(string.Join(" " , result));
    }
}

