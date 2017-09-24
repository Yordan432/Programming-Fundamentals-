using System;
using System.Collections.Generic;
using System.Linq;
class RotateandSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k =int.Parse(Console.ReadLine());

        int[] sum = new int[numbers.Length];
        for (int i = 0; i < k; i++)
        {
            var lastElement = numbers[numbers.Length - 1];
            for (int j = numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = lastElement;

            for (int j = 0; j < numbers.Length; j++)
            {
                sum[j] += numbers[j];
            }
        }
        Console.WriteLine(string.Join(" " , sum));
    }

    private static void FullSolve()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = int.Parse(Console.ReadLine());
        int[] sum = new int[numbers.Length];

        for (int i = 0; i < k; i++)
        {
            var lastNumber = numbers[numbers.Length - 1];

            for (int j = numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = lastNumber;
            for (int j = 0; j < numbers.Length; j++)
            {
                sum[j] += numbers[j];
            }
        }
        Console.WriteLine(string.Join(" ", sum));
    }
}

