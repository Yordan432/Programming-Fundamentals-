using System;
using System.Linq;

class OccurrenceLargerArr
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var count = 0;

        double p = double.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (p < numbers[i])
            {
                count++;
            }
        }
        Console.WriteLine(count);
       
    }
}

