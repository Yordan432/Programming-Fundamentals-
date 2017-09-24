using System;
using System.Collections.Generic;
using System.Linq;
class MirrorImage
{
    static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();  
        string input = Console.ReadLine();
        while (input != "Print")
        {
            var parseToNumber = int.Parse(input);
            ReverseLeft(numbers, parseToNumber);
            ReverseRight(numbers, parseToNumber);

            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" " , numbers));     
    }
    private static void ReverseRight(List<string> numbers, int parseToNumber)
    {
        int lenght = numbers.Count - 1;
        if (parseToNumber < lenght)
        {
            for (int i = parseToNumber + 1; i <=lenght; i++)
            {
                string temp = numbers[lenght];
                numbers.RemoveAt(lenght);
                numbers.Insert(i, temp);
            }
        }

    }

    private static void ReverseLeft(List<string> numbers, int parseToNumber)
    {
        for (int i = 0; i < parseToNumber; i++)
        {
            string temp = numbers[parseToNumber - 1];
            numbers.RemoveAt(parseToNumber - 1);
            numbers.Insert(i, temp);
        }
    }
}

