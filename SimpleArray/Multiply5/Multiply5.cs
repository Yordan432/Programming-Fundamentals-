using System;
class Multiply5
{
    static void Main()
    {
     
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }
        Console.WriteLine(string.Join(" " , numbers));
    }
}

