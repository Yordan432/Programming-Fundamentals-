using System;
using System.Collections.Generic;
using System.Linq;
class SafeManipulation
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();

        string[] input = Console.ReadLine().Split();
        while (input[0] != "END")
        {
            if (input[0] != "Reverse" && input[0] != "Distinct" && input[0] != "Replace")
            {
                Console.WriteLine("Invalid input!");
            }
            if (input[0] == "Reverse")
            {
                Array.Reverse(words);
            }
            if (input[0] == "Distinct")
            {
                var uniqueElements = words.Distinct();
                words = uniqueElements.ToArray();
            }
            if (input[0] == "Replace")
            {
                int len = words.Length;
                var index = input[1];
                int convertIndx = int.Parse(index);

                if (convertIndx >=len || convertIndx < 0)
                {
                    Console.WriteLine("Invalid input!");
                   
                }
                else
                {
                    var indexs = input[1];
                    int convertIndex = int.Parse(index);
                    var oldWord = words[convertIndex];
                    var newWord = input[2];
                    words = words.Select(x => x.Replace(oldWord, newWord)).ToArray();
                }
            }
            input = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(", " , words));
    }
}

