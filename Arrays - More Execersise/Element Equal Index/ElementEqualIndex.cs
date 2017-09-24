using System;
using System.Linq;

class ElementEqualIndex
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var index = 0;
        for (int i = 0; i < numbers.Length; i++)
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

