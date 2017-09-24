using System;
using System.Linq;
class Reverse_String
{
    static void Main()
    {
        string text = Console.ReadLine();

        char[] toCharArrayText = text.ToCharArray().Reverse().ToArray();
        Console.WriteLine(string.Join("", toCharArrayText));
    }
}

