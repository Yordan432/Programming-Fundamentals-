using System;

class StringRepeater
{
    static void Main()
    {
        string str = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        var result = RepeatStr(str, n);
        Console.WriteLine(result);
    }
    private static string RepeatStr(string str, int n)
    {
        string empty = string.Empty;
        for (int i = 0; i < n; i++)
        {
            empty += str;
        }
        return empty;
    }
}

