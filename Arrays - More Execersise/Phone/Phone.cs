using System;
using System.Linq;

class Phone
{
    static void Main()
    {
        string[] phonebook = Console.ReadLine().Split();
        string[] names = Console.ReadLine().Split();


        string[] input = Console.ReadLine().Split();
        int index = 0;
        FindIndexCurrent(index, phonebook, names);
        while (input[0] != "done")
        {
            for (int i = 0; i < phonebook.Length; i++)
            {
                if (input[0] == "call" && input[1].Contains(phonebook[index]))
                {
                    Console.WriteLine("calling {0}...", names[index]);
                    break;
                }
                else if (input[0] == "call" && input[1].Contains(names[index]))
                {
                    Console.WriteLine("calling {0}" , phonebook[index]);
                    break;
                }
            }
            input = Console.ReadLine().Split();
            index++;
        }

        
    }

    private static void FindIndexCurrent(int index, string[] phonebook, string[] names)
    {
        var lenghtPhonebook = phonebook.Length;
        var lenghtNames = names.Length;

        for (int i = 0; i < phonebook.Length; i++)
        {

        }
    }
}

