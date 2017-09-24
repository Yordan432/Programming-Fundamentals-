using System;
using System.Linq;

class OddNumbersOddPositions
{
    static void Main()
    {
        var arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            if (i % 2 != 0 && arrNumbers[i] % 2 !=0)
            {
                Console.WriteLine(string.Join(" " ,$"Index {i} -> {arrNumbers[i]}"));
            }
        }
    }
}

