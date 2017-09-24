using System;
using System.Collections.Generic;
using System.Linq;
class Shellbound
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        Dictionary<string, List<int>> cityNumbers = new Dictionary<string, List<int>>();
       // Dictionary<string, HashSet<int>> cityNumbers = new Dictionary<string, HashSet<int>>();

        while (input[0] != "Aggregate")
        {
            var city = input[0];
            var number = int.Parse(input[1]);

            if (!cityNumbers.ContainsKey(city))
            {
                cityNumbers[city] = new List<int>();
            }
            if (!cityNumbers[city].Contains(number))
            {
                cityNumbers[city].Add(number);
            }
            input = Console.ReadLine().Split(' ');
        }

        foreach (var city in cityNumbers)
        {
            string region = city.Key;
            var shell = city.Value;

            Console.WriteLine($"{region} -> {string.Join(", ", shell)} ({Math.Ceiling(shell.Sum() - shell.Average())})");
        }
    }
}

