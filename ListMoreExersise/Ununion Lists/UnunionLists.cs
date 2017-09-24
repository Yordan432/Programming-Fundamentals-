using System;
using System.Linq;
using System.Collections.Generic;
class UnunionLists
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] currentNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int number in currentNumbers)
            {
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
                else
                {
                    numbers.RemoveAll(e => e == number);
                }
            }
        }
        numbers.Sort();
        Console.WriteLine(string.Join(" ", numbers));


    }


}

