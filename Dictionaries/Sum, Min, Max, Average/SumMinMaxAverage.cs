using System;
using System.Collections.Generic;
using System.Linq;
class SumMinMaxAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> result = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            result.Add(currentNumber);
        }

        Console.WriteLine("Sum = {0}" , result.Sum());
        Console.WriteLine("Min = {0}" , result.Min());
        Console.WriteLine("Max = {0}" , result.Max());
        Console.WriteLine("Average = {0}" , result.Average());
    }
    static void AlogirithmWay()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine(sum);
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum / n);
    }
}

