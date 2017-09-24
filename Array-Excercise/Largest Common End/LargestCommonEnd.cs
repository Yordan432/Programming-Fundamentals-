using System;
using System.Collections.Generic;
using System.Linq;
class LargestCommonEnd
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split(' ');
        string[] secondArray = Console.ReadLine().Split(' ');

        var minLenghtArray = Math.Min(firstArray.Length, secondArray.Length);

        int leftCounter = 0;
        int rightCounter = 0;

        for (int i = 0; i < minLenghtArray; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                leftCounter++;
            }
        }

        for (int i = 0; i < minLenghtArray; i++)
        {
            if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - 1 - i])
            {
                rightCounter++;
            }
        }
        Console.WriteLine(Math.Max(leftCounter , rightCounter));


        //int leftCounter = leftCounter = CheckArrays(firstArray, secondArray, minLenghtArray);
        //Array.Reverse(firstArray);
        //Array.Reverse(secondArray);
        //int rightCounter = leftCounter = CheckArrays(firstArray, secondArray, minLenghtArray);

        //Console.WriteLine(Math.Max(leftCounter, rightCounter));
    }

    private static int CheckArrays(string[] firstArray, string[] secondArray, int minLenghtArray)
    {
        int counter = 0;
        for (int i = 0; i < minLenghtArray; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                counter++;
            }
            else
            {
                
            }
        }

        return counter;
    }
}

