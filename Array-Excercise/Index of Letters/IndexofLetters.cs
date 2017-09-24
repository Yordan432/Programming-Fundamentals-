using System;
using System.Collections.Generic;
using System.Linq;
class IndexofLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        char[] words = word.ToCharArray();

        int index = 0;
        char[] letters = new char[26];
        for (char i = 'a'; i <= 'z'; i++)
        {
            letters[index] = (char)(i);
            index++;
        }
        for (char inx = words['0']; inx < words.Length; inx++)
        {
            Print(word, words, letters, inx);
        }


    }

    private static void Print(string word, char[] words, char[] letters, char i)
    {
        for (int j = 0; j < word.Length; j++)
        {
            var lenghtLetter = letters[j];
            if (words.Contains(letters[j]))
            {
                Console.WriteLine($"{letters[j]} -> {j}");
            }
        }
    }
}

