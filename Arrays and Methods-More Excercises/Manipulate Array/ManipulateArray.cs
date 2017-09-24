using System;
using System.Collections.Generic;
using System.Linq;
class ManipulateArray
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] current = Console.ReadLine().Split();
            if (current[0] == "Reverse")
            {
                Array.Reverse(words);
            }
            if (current[0] == "Distinct")
            {
                var uniqueElements = words.Distinct();
                words = uniqueElements.ToArray();

            }
            if (current[0] == "Replace")
            {
                var index = current[1];
                int convertIndex = int.Parse(index);
                var oldWord = words[convertIndex]; 
                var newWord = current[2];

               words = words.Select(x => x.Replace(oldWord, newWord)).ToArray();
            }
        }
        Console.WriteLine(string.Join(", " , words));
    }
}

