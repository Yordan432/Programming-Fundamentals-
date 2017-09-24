using System;
using System.Linq;
using System.Collections.Generic;
class SumAdjacentEqualNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
        numbers.Add(int.MaxValue);


        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                var sumLeft = numbers[i] + numbers[i + 1];
                numbers[i + 1] = sumLeft;
                numbers.RemoveAt(i);
                i -= 1;
            }
        }
        numbers.RemoveAt(numbers.Count - 1);
        Console.WriteLine(string.Join(" ", numbers));
        //List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        //int index = 0;

        //while (true)
        //{
        //    if (numbers[index] == numbers[index + 1])
        //    {
        //        numbers[index] += numbers[index + 1];
        //        numbers.Remove(numbers[index + 1]);
        //        index = 0;
        //    }
        //    else
        //    {
        //        index++;
        //        if (index == numbers.Count - 1)
        //        {
        //            Console.WriteLine(string.Join(" ", numbers));
        //            return;
        //        }
        //    }
        //}



        //do
        //{
        //    if (numbers[index] == numbers[index + 1])
        //    {
        //        numbers[index] += numbers[index + 1];
        //        numbers.Remove(numbers[index + 1]);
        //        continue;
        //    }
        //    else 
        //    {
        //        index++;
        //    }
        //} while (numbers[index] == numbers[index + 1]);


    }
}

