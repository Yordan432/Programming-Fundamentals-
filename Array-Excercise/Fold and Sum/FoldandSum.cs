using System;
using System.Linq;

class FoldandSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        int[] firstElements = new int[k];
        int[] middleElement = new int[k * 2];
        int[] lastElements = new int[k];

        for (int i = 0; i < k; i++)
        {
            var firstElement = numbers[i];
            firstElements[i] = firstElement; // add first elemenets in first array
        }
        for (int i = 0; i < k; i++)
        {
            lastElements[i] = numbers[numbers.Length - i - 1]; // add second elements in second array
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            while (i != k)
            {
                numbers[i] = 0; // make first element zero
                i++;
            }
            break;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            while (i != k)
            {
                numbers[numbers.Length - i - 1] = 0; // make last element zero
                i++;
            }
            break;
        }
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            
            if (numbers[i] != 0)
            { 
                middleElement[index] = numbers[index + k]; // check if element is not equal zero and add in middle array
                index++;
            }
        }
        int[] lastArray = new int[k * 2];
        Array.Reverse(firstElements);

        for (int i = 0; i < firstElements.Length ; i++)
        {
            lastArray[i] = firstElements[i]; // add first elements 
        }
        for (int i = 0; i < lastElements.Length; i++)
        {
            lastArray[i + k] = lastElements[i];
        }


        int[] sum = new int[lastArray.Length];
        for (int i = 0; i < lastArray.Length; i++)
        {
           sum[i] = lastArray[i] + middleElement[i];
        }
        Console.WriteLine(string.Join(" " , sum));
    }
}

