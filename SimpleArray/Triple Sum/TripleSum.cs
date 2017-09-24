using System;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int count = 0;
        for (int a = 0; a < numbers.Length; a++)
        {
            for (int j = a + 1; j < numbers.Length; j++)
            {
                var sum = numbers[a] + numbers[j];
                if (numbers.Contains(sum))
                {
                    Console.WriteLine($"{numbers[a]} + {numbers[j]} == {sum}");
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

