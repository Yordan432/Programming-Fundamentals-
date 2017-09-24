using System;
using System.Collections.Generic;
using System.Linq;
class ArrayManipulator
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string[] input = Console.ReadLine().Split(' ');
        while (true)
        {
            if (input[0] == "print")
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                return;
            }
            if (input[0] == "add")
            {
                var index = int.Parse(input[1]);
                var element = int.Parse(input[2]);
                numbers.Insert(index, element);
            }
            if (input[0] == "addMany")
            {
                int inputLenght = input.Length;
                var index = int.Parse(input[1]);


                for (int i = 0; i < inputLenght - 2; i++)
                {
                    int currentElementsAfterInedex = int.Parse(input[i + 2]);
                    numbers.Insert(index, currentElementsAfterInedex);
                    index++;
                }
            }
            if (input[0] == "contains")
            {
                int index = int.Parse(input[1]);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers.Contains(index))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(-1);
                        break;
                    }
                }
            }
            if (input[0] == "remove")
            {
                var index = int.Parse(input[1]);
                numbers.RemoveAt(index);
            }
            if (input[0] == "shift")
            {
                int count = int.Parse(input[1]);
                for (int i = 0; i < count; i++)
                {
                    var firstElement = numbers[0];
                    numbers.Remove(numbers[0]);
                    numbers.Insert(numbers.Count, firstElement);
                }
            }
            if (input[0] == "sumPairs")
            {
                int lenght = numbers.Count;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }

            }
            input = Console.ReadLine().Split(' ');
        }
    }
}

