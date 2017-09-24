using System;
using System.Collections.Generic;
using System.Linq;

class DecodeRadioFrequenc
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ').ToArray();
        List<char> words = new List<char>();

        for (int i = 0; i < numbers.Length; i++)
        {
            double[] parse = numbers[i].Split(new char[] {'.' }).Select(double.Parse).ToArray();
            var currentNumber = parse[0];
            char convertToChar = (char)currentNumber;
            var currentNumbers = parse[1];
            var convertToCharcter = (char)currentNumbers;
            words.Insert(i, convertToChar);
            words.Insert(words.Count - i - 1, convertToCharcter);
        }
        words.Reverse();
        words.TrimExcess();
        foreach (var item in words)
        {
            if (item != '\0')
            {
                Console.Write(item);
            }
            
        }
        Console.WriteLine();
    }
}

