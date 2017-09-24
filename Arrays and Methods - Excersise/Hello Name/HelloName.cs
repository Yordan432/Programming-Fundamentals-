using System;
class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        var gretting = PrintName(name);
        Console.WriteLine(gretting);
    }
    static string PrintName(string name)
    {
        var grretting = $"Hello, {name}!";

        return grretting;
    }
}

