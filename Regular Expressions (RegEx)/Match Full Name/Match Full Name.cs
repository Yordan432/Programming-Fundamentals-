using System;
using System.Text.RegularExpressions;
class MatchFullName
{
    static void Main()
    {
        string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        string name = Console.ReadLine();
        MatchCollection matches = Regex.Matches(name, regex);

        foreach (Match item in matches)
        {
            Console.Write(item.Value + " ");
        }
    }
}

