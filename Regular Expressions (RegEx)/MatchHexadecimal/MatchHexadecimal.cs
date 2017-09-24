using System;
using System.Text.RegularExpressions;

class MatchHexadecimal
{
    static void Main()
    {
        string regex = @"\b(?:0x)?([0-9A-F]+)\b";

        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, regex);

        foreach (Match item in matches)
        {
            Console.Write(item.Value + " ");
        }
        Console.WriteLine();
    }
}

