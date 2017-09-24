using System;
using System.Collections.Generic;
using System.Linq;
class CharacterMultiplier
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        var sum = 0;
        var firstWord = input[0];
        var secondWord = input[1];

        var min = Math.Min(firstWord.Length, secondWord.Length);

        for (int i = 0; i < min; i++)
        {
            var firstWords = (int)firstWord[i];
            var secondWords = (int)secondWord[i];

            sum += firstWords * secondWords;
        }
        var longerWord = firstWord.Length > secondWord.Length ? firstWord : secondWord;

        for (int i = min; i < longerWord.Length; i++)
        {
            sum += longerWord[i];
        }
        Console.WriteLine(sum);

        //MultipliedChar(input[0], input[1]);
    }

    private static void MultipliedChar(string firstWord, string secondWord)
    {
        List<int> result = new List<int>();
        var toCharFirstWord = firstWord.ToCharArray();
        var toCharSecondWord = secondWord.ToCharArray();

        for (int i = 0; i < toCharFirstWord.Length; i++)
        {
            var firstWords = (int)toCharFirstWord[i];
            var secondWords = (int)toCharSecondWord[i];

            var miltipliedWords = firstWords * secondWords;
            var firstDigit = TakeFirstDigitFromNumber(miltipliedWords);
            result.Add(firstDigit);
        }
    }

    private static int TakeFirstDigitFromNumber(int miltipliedWords)
    {
        var firstNumber = miltipliedWords.ToString();
        firstNumber.ToCharArray();
        var firstDigit = firstNumber[0].ToString();

        return int.Parse(firstDigit);

    }
}

