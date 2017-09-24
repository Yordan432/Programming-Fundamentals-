using System;
using System.Collections.Generic;
using System.Linq;
class JapaneseRoulette
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string[] commands = Console.ReadLine().Split(new char[] { ' ', ',' }).ToArray();
       
        for (int i = 0; i < commands.Length; i++)
        {
            string[] tokens = commands[i].Split(',');
            string diection = tokens[0];
            int power = int.Parse(tokens[1]);

            switch (diection)
            {
                case "Right":

                    break;

                case "Left":
                    break;
            }
        }
    }
}

