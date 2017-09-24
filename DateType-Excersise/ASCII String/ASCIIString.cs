using System;

class ASCIIString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = string.Empty;

        for (var i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            char convert = (char)currentNumber;
            word += convert;
        }
        Console.WriteLine(word);
    }
}

