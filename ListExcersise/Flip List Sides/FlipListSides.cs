using System;
using System.Linq;
using System.Collections.Generic;
class FlipListSides
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool[] isTrueElements = new bool[numbers.Count];
        isTrueElements[0] = true;
        isTrueElements[isTrueElements.Length - 1] = true;
        isTrueElements[isTrueElements.Length / 2] = true;
        int indx = 0;
        for (int i = 0; i < numbers.Count / 2; i++)
        {
            var temp = numbers[i + 1];
            isTrueElements[i + 1] = true;
            numbers[i + 1] = numbers[numbers.Count - i - 2];
            numbers[numbers.Count - i - 2] = temp;
            isTrueElements[isTrueElements.Length - i - 2] = true;

            while (isTrueElements[indx] == true)
            {
                indx++;
                if (indx == isTrueElements.Length - 1)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }
            }
            indx = 0;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

