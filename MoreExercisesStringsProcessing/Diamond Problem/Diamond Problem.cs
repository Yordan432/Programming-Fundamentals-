using System;
using System.Collections.Generic;
using System.Linq;
class DiamondProblem
{
    static void Main()
    {
        string input = Console.ReadLine();

        Diamod(input);
    }

    private static void Diamod(string input)
    {
        int count = 0;
        int countCarad = 0;
        List<string> diamodWords = new List<string>();
        char[] date = input.ToCharArray();
        for (int i = 0; i < date.Length; i++)
        {
            if (date[i] == '<')
            {
                countCarad = count;
                while (date[countCarad] != '>')
                {
                    diamodWords.Add(date[countCarad].ToString());
                    countCarad++;
                    if (date.Length - 1 == countCarad)
                    {
                        break;
                    }
                }
                int currentCard = FoundCardDiamond(diamodWords);
                if (currentCard == 0)
                {
                    Console.WriteLine("Better luck next time");
                    return;
                }
                PrintResult(currentCard);
                diamodWords.Clear();
            }
            count++;
        }
    }

    private static void PrintResult(int currentCard)
    {
        Console.WriteLine("Found {0} carat diamond" , currentCard);
    }

    private static int FoundCardDiamond(List<string> diamodWords)
    {
        int sum = 0;
        for (int i = 0; i < diamodWords.Count; i++)
        {
            int parse;
            bool isParseNumber = int.TryParse(diamodWords[i], out parse);
            if (isParseNumber)
            {
                sum += parse;
            }
        }
        return sum;
    }
}

