using System;
using System.Text.RegularExpressions;

class MatchDates
{
    static void Main()
    {
        string regex = @"(\d{2})(\/?.?-?)\w{3}\2\d{4}\b";

        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, regex);

        foreach (Match item in matches)
        {
            string day = item.Value;

            var date = day.Split(new char[] { '/', '.', '-' });

            Console.WriteLine($"Day: {date[0]}, Month: {date[1]}, Year: {date[2]}");
        }
    }
}

