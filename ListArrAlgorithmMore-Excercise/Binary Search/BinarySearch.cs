using System;
using System.Collections.Generic;
using System.Linq;
class BinarySearch
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        LinearSearch(numbers, n);

        BinarySearchMethod(numbers, n);

    }

    private static void BinarySearchMethod(int[] numbers, int n)
    {
        Array.Sort(numbers);
        bool isFoundNumber = false;
        int counter = 0;
        var firstElement = 0;
        var lastElement = numbers.Length - 1;
        var middlePart = 0;
        while (firstElement <= lastElement)
        {
            counter++;
            middlePart = (firstElement + lastElement) / 2;
            if (n > numbers[middlePart])
            {
                firstElement = middlePart + 1;
            }
            else if (n < numbers[middlePart])
            {
                lastElement = middlePart - 1;
            }
            else
            {
                isFoundNumber = true;
                break;
            }
        }
        if (isFoundNumber)
        {
            Console.WriteLine("Binary search made {0} iterations", counter);
        }
        else
        {
            Console.WriteLine("Binary search made {0} iterations", counter);
        }
    }

    private static int LinearSearch(int[] numbers, int n)
    {
        int counter = 1;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == n)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Linear search made {0} iterations", counter);
                break;
            }
            counter++;
        }
        if (!numbers.Contains(n))
        {
            Console.WriteLine("No");
            Console.WriteLine("Linear search made {0} iterations", counter);
        }
        return counter;
    }
}

