using System;
using System.Collections.Generic;
using System.Linq;
class ShoppingSpree
{
    static void Main()
    {
        var budget = double.Parse(Console.ReadLine());

        Dictionary<string, double> dict = new Dictionary<string, double>();

        string[] input = Console.ReadLine().Split();

        while (input[0] != "end")
        {
            string product = input[0];
            double price = double.Parse(input[1]);

            if (!dict.ContainsKey(product))
            {
                dict.Add(product, 0.0);
            }
            dict[product] = price;

            input = Console.ReadLine().Split();
        }
        foreach (var item in dict)
        {
            string key = item.Key;
            foreach (var value in dict.Values)
            {
                budget -= value;
            }
            if (budget > 0)
            {
                foreach (var product in dict.OrderBy(x => x.Value).Reverse())
                {
                    Console.WriteLine($"{product.Key} costs {product.Value:f2}");            
                }
                return;      
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
                return;
            }

        }
    }
}

