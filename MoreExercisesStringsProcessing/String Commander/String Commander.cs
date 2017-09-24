using System;
using System.Collections.Generic;
using System.Linq;
class StringCommander
{
    static void Main()
    {
        string[] dateInput = Console.ReadLine().Split(' ');
        string input = Console.ReadLine();
        List<string> firstWord = new List<string>();
        while (input != "end")
        {
            var tokens = input.Split(' ');
            string command = tokens[0];
            int countRotate = int.Parse(tokens[1]);
            firstWord.AddRange(dateInput);
            string temp = firstWord[0];
            if (command == "Left")
            {
                for (int i = 0; i < countRotate; i++)
                {
                    firstWord[0] = firstWord[firstWord.Count - 1];
                }
                
            }
            firstWord[0] = temp;
            input = Console.ReadLine();
        }
    }
}

