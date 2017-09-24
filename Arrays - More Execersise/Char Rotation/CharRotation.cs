using System;
using System.Linq;

class CharRotation
{
    static void Main()
    {
        string words = Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        char[] result = new char[numbers.Length];


        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result[i] = (char)(words[i] - numbers[i]);
            }
            else
            {
                result[i] = (char)(words[i] + numbers[i]);
            }
        }
        Console.WriteLine(string.Join("" , result));
    }
}

