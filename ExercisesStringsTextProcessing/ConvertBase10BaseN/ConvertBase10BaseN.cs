using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class ConvertBase10BaseN
{
    static void Main()
    {
        var numberBase = Console.ReadLine().Split(' ').ToArray();
        var convertNumToBase = int.Parse(numberBase[0]);

        List<BigInteger> result = new List<BigInteger>();
        var number = BigInteger.Parse(numberBase[1]);
        while (number != 0)
        {
            BigInteger remainder = number % convertNumToBase;
            result.Add(remainder);
            number /= convertNumToBase;
        }
        result.Reverse();
        Console.WriteLine(string.Join("", result));

    }
}

