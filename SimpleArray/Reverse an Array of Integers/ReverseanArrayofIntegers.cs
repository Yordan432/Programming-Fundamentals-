using System;
using System.Collections.Generic;

class ReverseanArrayofIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < number; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            arr[i] = currentNum;
            stack.Push(arr[i]);
        }
        Console.WriteLine(string.Join(" " , stack)); 
    }

    static void Header()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];


        for (int i = 0; i < number; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            arr[i] = currentNum;
        }
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

