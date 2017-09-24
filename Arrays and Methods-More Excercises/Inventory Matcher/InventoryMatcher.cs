using System;
using System.Collections.Generic;
using System.Linq;
class InventoryMatcher
{
    static void Main()
    {
        List<string> products = Console.ReadLine().Split(' ').ToList();
        List<long> quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        List<decimal> price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        string input = Console.ReadLine();
        while (input != "done")
        {
            int index = products.IndexOf(input);
            Console.WriteLine($"{products[index]} costs: {price[index]}; Available quantity: {quantities[index]}");
            input = Console.ReadLine();
        }


    }
}

