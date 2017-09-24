using System;
using System.Linq;

class ReverseanArrayofStrings
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < words.Length / 2; i++)
        {
            var first = words[i];
            var last = words[words.Length - i - 1];
            
            var temp = words[i];
            words[i] = last;
            words[words.Length - i - 1] = temp;
        }
        Console.WriteLine(string.Join(" " , words));
    }
}

