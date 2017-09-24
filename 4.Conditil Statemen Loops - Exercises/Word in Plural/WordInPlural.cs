using System;

class WordInPlural
{
    static void Main()
    {
        var word = Console.ReadLine().Trim();
        if (word.EndsWith("y"))
        {
            string replace = word.Remove(word.Length - 1);
            Console.WriteLine(replace + "ies");
        }
        else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh")|| word.EndsWith("x")|| word.EndsWith("z"))
        {
            Console.WriteLine(word + "es");
        }
        else
        {
            Console.WriteLine(word + "s");
        }
    }
}

