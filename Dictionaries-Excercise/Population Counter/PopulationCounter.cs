using System;
using System.Collections.Generic;
using System.Linq;
class PopulationCounter
{
    static void Main()
    {
        var cityCountryPopulation = new Dictionary<string, SortedDictionary<string, ulong>>();
        string[] line = Console.ReadLine().Split('|');

        while (line[0] != "report")
        {
            var city = line[0];
            var country = line[1];
            ulong population = ulong.Parse(line[2]);

            if (!cityCountryPopulation.ContainsKey(country))
            {
                cityCountryPopulation[country] = new SortedDictionary<string, ulong>();
            }
            if (!cityCountryPopulation[country].ContainsKey(city))
            {
                cityCountryPopulation[country].Add(city, population);
            }
            var orderby = cityCountryPopulation.OrderBy(x => x.Value[country]);


            line = Console.ReadLine().Split('|');
        }

        //var sorted = cityCountryPopulation.OrderBy(x => x.Value).ToList();


        foreach (var country in cityCountryPopulation.OrderByDescending(x => x.Key))
        {
            Console.WriteLine($"{country.Key}: ({string.Join(" " , country.Value)})");
            foreach (var cityPopulation in country.Value)
            {
                var city = cityPopulation.Key;
                var population = cityPopulation.Value;
                Console.WriteLine($"=> {cityPopulation.Key}: {cityPopulation.Value}");
            }
        }
    }
}

