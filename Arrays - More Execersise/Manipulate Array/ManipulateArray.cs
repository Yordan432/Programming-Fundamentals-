using System;
using System.Collections.Generic;
using System.Linq;
class ManipulateArray
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').ToArray();

        var listOfNumbers = new List<string>();
        int index = 0;

        while (input[0] != "end")
        {
            if (input[0] == "push")
            {
                listOfNumbers.Add(input[1]);
                index++;
            }
            if (input[0] == "pop")
            {
                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
            }
            if (input[0] == "removeAt")
            {
                var last = int.Parse(input[1]);
                listOfNumbers.RemoveAt(last);
            }
            if (input[0] == "clear")
            {
                listOfNumbers.Clear();
            }
            input = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine(string.Join(" ", listOfNumbers));
    }
}

