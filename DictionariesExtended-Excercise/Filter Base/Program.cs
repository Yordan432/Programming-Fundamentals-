using System;
using System.Collections.Generic;
using System.Linq;
class FilterBase
{
    static void Main()
    {
        Dictionary<string, int> age = new Dictionary<string, int>();
        Dictionary<string, string> position = new Dictionary<string, string>();
        Dictionary<string, double> salary = new Dictionary<string, double>();

        string[] input = Console.ReadLine().Split(' ');
        while (input[0] != "filter" && input[0] != "base")
        {
            int parseIntegerNumber;
            bool isInteger = int.TryParse(input[2], out parseIntegerNumber);
            double parseDoubleNumber;
            bool isDouble = double.TryParse(input[2], out parseDoubleNumber);

            if (isInteger)
            {
                age.Add(input[0], parseIntegerNumber);
            }

            else if (isDouble)
            {
                salary.Add(input[0], parseDoubleNumber);
            }
            else
            {
                position.Add(input[0], input[2]);
            }

            input = Console.ReadLine().Split(' ');
        }

        string word = Console.ReadLine().ToLower();

        if (word == "age")
        {
            foreach (var item in age)
            {
                Console.WriteLine($"Name: {item.Key}");
                Console.WriteLine($"Age: {item.Value}");
            }
        }
        else if (word == "salary")
        {
            foreach (var item in salary)
            {
                Console.WriteLine($"Name: {item.Key}");
                Console.WriteLine($"Salary: {item.Value:f2}");
                Console.WriteLine("====================");
            }
        }
        else if (word == "position")
        {
           foreach (var item in position)
           {
                var name = item.Key;
                var postion = item.Value;
                Console.WriteLine($"Name: {item.Key}");
                Console.WriteLine($"Position: {item.Value}");
                Console.WriteLine("====================");
           }
        }
    }
}

