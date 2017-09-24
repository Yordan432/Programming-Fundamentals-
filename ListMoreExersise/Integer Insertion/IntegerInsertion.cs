using System;
using System.Linq;
using System.Collections.Generic;

class IntegerInsertion
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        string input = Console.ReadLine();
        while (input != "end")
        {
            var parse = int.Parse(input);
            var digit = input[0] - '0';

            numbers.Insert(digit, parse);

            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" " , numbers));
    }
}

