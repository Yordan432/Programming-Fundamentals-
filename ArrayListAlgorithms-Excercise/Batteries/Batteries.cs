using System;
using System.Collections.Generic;
using System.Linq;
class Batteries
{
    static void Main()
    {
        double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] perHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int amountHour = int.Parse(Console.ReadLine());
        int indx = 1;
        double[] bateries = new double[capacities.Length];
        for (int i = 0; i < perHour.Length; i++)
        {
            var amountToHour = perHour[i] * amountHour;
            var result = capacities[i] - amountToHour;
            bateries[i] = result;
            Console.WriteLine($"Battery {i}: {bateries[i]:f2}mAh");

        }
        //for (int i = 0; i < bateries.Length; i++)
        //{
        //    if (bateries[i] < 0)
        //    {
        //        Console.WriteLine($"Battery{i} dead");
        //    }
        //}
        Console.WriteLine(string.Join(" " , bateries));
    }
}

