using System;
using System.Collections.Generic;
using System.Linq;
class UpgradedMatcher
{
    static void Main()
    {
        string[] products = Console.ReadLine().Split(' ').ToArray();
        int[] quantities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        string[] input = Console.ReadLine().Split(' ');
        while (input[0] != "done")
        {
            
            input = Console.ReadLine().Split(' ');
        }
    }
}

