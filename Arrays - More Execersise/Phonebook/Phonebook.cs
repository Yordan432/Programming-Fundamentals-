using System;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        var phonebook = Console.ReadLine().Split(' ').ToArray();
        var names = Console.ReadLine().Split(' ').ToArray();

        var input = Console.ReadLine();
        while (input != "done")
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == input)
                {
                    Console.WriteLine(string.Join(" " ,$"{names[i]} -> {phonebook[i]}"));
                }
            }
            input = Console.ReadLine();
        }
    }
}

