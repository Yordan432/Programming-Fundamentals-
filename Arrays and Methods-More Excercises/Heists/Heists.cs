using System;
using System.Collections.Generic;
using System.Linq;
class Heists
{
    static void Main()
    {
        int[] price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string[] input = Console.ReadLine().Split(' ');
        while (input[0] != "Jail Time")
        {

            input = Console.ReadLine().Split(' ');
        }
    }
}

