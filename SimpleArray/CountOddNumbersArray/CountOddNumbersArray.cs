using System;
using System.Linq;

class CountOddNumbersArray
{
    static void Main()
    {
        var arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var count = 0;

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            if (arrNumbers[i] % 2 != 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

