using System;
using System.Collections.Generic;
using System.Linq;
class Wardrobe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var clothesColor = new Dictionary<string, Dictionary<string, int>>();

        List<string> allClothes = new List<string>();

        int counterClothes = 1;
        for (int i = 0; i < n; i++)
        {
            string[] words = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string colorClothes = words[0];
            string[] clothes = words[1].Split(',');

            if (!clothesColor.ContainsKey(colorClothes))
            {
                clothesColor.Add(colorClothes, new Dictionary<string, int>());
            }
            foreach (var currentCloth in clothes)
            {
                var currentClothes = clothesColor[colorClothes];
                if (!currentClothes.ContainsKey(currentCloth))
                {
                    currentClothes.Add(currentCloth, 0);
                }
                currentClothes[currentCloth]++;
            }
        }

        string[] findWord = Console.ReadLine().Split(' ');
        string searchColor = findWord[0];
        string searchClothes = findWord[1];

        foreach (var item in clothesColor)
        {
            var color = item.Key;
            var clothes = item.Value;

            Console.WriteLine($"{color} clothes:");
            foreach (var clothesAndCount in clothes)
            {
                var currentClothes = clothesAndCount.Key;
                var amount = clothesAndCount.Value;
                Console.Write($"* {currentClothes} - {amount}");
                if (color == searchColor && currentClothes == searchClothes)
                {
                    Console.WriteLine(" (found!)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

