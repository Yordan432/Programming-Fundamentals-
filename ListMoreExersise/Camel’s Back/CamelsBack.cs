using System;
using System.Linq;
using System.Collections.Generic;
class CamelsBack
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        int rounds = 1;
        for (int i = 0; i < n; i++)
        {
            var first = numbers[0];
            var last = numbers[numbers.Count - 1];
            numbers.Remove(first);
            numbers.Remove(last);
            if (numbers.Count == n)
            {
                Console.WriteLine("{0} rounds" , rounds);
                Console.WriteLine("remaining: " + string.Join(" ", numbers));
                return;
            }
            rounds++;
        }    
    }
}

