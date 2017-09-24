using System;
using System.Collections.Generic;
using System.Linq;
class AdvertisementMessage
{
    static void Main()
    {
        string[] phrases = new string[]
        {"Excellent product." ,
         "Such a great product.",
         "I always use that product.",
         "Best product of its category.",
         "Exceptional product.",
         "I can’t live without this product.",
        };
        string[] events = new string[]
        {"Now I feel good.",
         "I have succeeded with this product.",
         "Makes miracles. I am happy of the results!.",
         "I cannot believe but now I feel awesome.",
         "Try it yourself, I am very satisfied.",
         "I feel great!",
        };
        string[] authors = new string[]
        {
         "Diana",
         "Petya",
         "Stella",
         "Elena",
         "Katya",
         "Iva",
         "Annie",
         "Eva"
        };
        string[] cities = new string[]
        {
        "Burgas",
        "Sofia",
        "Plovdiv",
        "Varna",
        "Ruse"
        };

        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        string returnRandomWordPharse = null;
        string returnRandomWordEvents = null;
        string returnRandomWordAuthors = null;
        string returnRandomWordCity = null;
        for (int i = 0; i < n; i++)
        {
            var pharseRandom = rnd.Next(0, phrases.Length);
            var eventRandom = rnd.Next(0, events.Length);
            var authorsRandom = rnd.Next(0, authors.Length);
            var citiesRandom = rnd.Next(0, cities.Length);

            returnRandomWordPharse = Swap(pharseRandom, rnd, phrases);
            returnRandomWordEvents = Swap(eventRandom, rnd, events);
            returnRandomWordAuthors = Swap(authorsRandom, rnd, authors);
            returnRandomWordCity = Swap(citiesRandom, rnd, cities);

        }
        Console.WriteLine($"{returnRandomWordPharse} {returnRandomWordEvents} {returnRandomWordAuthors} - {returnRandomWordCity}");

    }
    private static string Swap(int pharseRandom, Random rnd, string[] phrases)
    {
        string randomWord = null;
        for (int i = 0; i < phrases.Length; i++)
        {
            var random = rnd.Next(phrases.Length);
            var swap = phrases[i];
            phrases[i] = phrases[random];
            phrases[random] = swap;
            randomWord = phrases[random];
        }
        return randomWord;
    }
}

