using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Program
{
    class BigFactorial
    {
        static void Main()
        {
            BigInteger factoriel = 1;
            decimal n = decimal.Parse(Console.ReadLine());
            for (int i = 2; i <=n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}