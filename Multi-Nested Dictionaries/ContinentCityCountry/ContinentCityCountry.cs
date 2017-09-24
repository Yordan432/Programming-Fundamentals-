using System;
using System.Collections.Generic;
using System.Linq;
class ContinentCityCountry
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var date = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

        for (int i = 0; i < n; i++)
        {
            var elements = Console.ReadLine().Split();
            var continent = elements[0];
            var country = elements[1];
            var city = elements[2];

            if (!date.ContainsKey(continent))
            {
                date[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!date[continent].ContainsKey(country))
            {
                date[continent][country] = new SortedSet<string>();
            }
            date[continent][country].Add(city);
        }
        foreach (var continents in date.Keys)
        {
            Console.WriteLine($"{continents}:");
            foreach (var contryTown in date[continents].Keys)
            {
                Console.WriteLine($"  {contryTown} -> {string.Join(", " ,date[continents][contryTown])}");
            }
        }
        
    }
}

