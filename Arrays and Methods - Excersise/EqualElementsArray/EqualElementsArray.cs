using System;
using System.Linq;

class EqualElementsArray
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isEqualElement = false;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var nextElement = numbers[i + 1];
            if (numbers[i] == nextElement)
            {
                isEqualElement = true;
            }
            else
            {
                isEqualElement = false;
            }
        }
        if (isEqualElement)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

