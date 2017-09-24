using System;
using System.Collections.Generic;
using System.Linq;
class CityContinentCountry
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            var continents = input[0];
            var countries = input[1];
            var city = input[2];

            if (!dictionary.ContainsKey(continents))
            {
                dictionary[continents] = new Dictionary<string, List<string>>();
            }
            if (!dictionary[continents].ContainsKey(countries))
            {
                dictionary[continents][countries] = new List<string>();
            }
            dictionary[continents][countries].Add(city);
        }
        foreach (var continents in dictionary.Keys)
        {
            Console.WriteLine($"{continents}:");
            foreach (var country in dictionary[continents].Keys)
            {
                var cities = string.Join(", " ,dictionary[continents][country]);
                Console.WriteLine($"  {country} -> {cities}");
            }
        }
    }
}

