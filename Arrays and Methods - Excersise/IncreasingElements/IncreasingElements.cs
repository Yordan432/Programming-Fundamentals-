using System;
using System.Linq;

class IncreasingElements
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isIncrementElement = false;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var nextElement = numbers[i + 1];
            if (numbers[i] < nextElement)
            {
                isIncrementElement = true;
            }
            else
            {
                isIncrementElement = false;
                break;
            }
        }

        if (isIncrementElement)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

