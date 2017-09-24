using System;
using System.Linq;

class LastEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int count = 1;
        Array.Reverse(input);
             
        for (int i = 0; i < input.Length - 1; i++)
        {
            var nextElement = input[i + 1];
            if (input[i] == nextElement)
            {
                count++;
            }
            if (count == 3)
            {
                Console.WriteLine($"{input[i]} {input[i]} {input[i]}");
                break;
            }
        }
    }
}

