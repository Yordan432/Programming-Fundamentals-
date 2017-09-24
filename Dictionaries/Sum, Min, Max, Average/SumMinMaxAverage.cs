using System;
using System.Collections.Generic;
using System.Linq;
class SumMinMaxAverage
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        var sum = numbers.Sum();
        var min = numbers.Min();
        var max = numbers.Max();
        var average = numbers.Average();

        Console.WriteLine("Sum = {0}" , sum);
        Console.WriteLine("Min = {0}" , min);
        Console.WriteLine("Max = {0}" , max);
        Console.WriteLine("Average = {0}" , average);
    }
}

