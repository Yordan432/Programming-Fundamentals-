using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        bool greather = firstArray[0] < secondArray[0];
        if (greather)
        {
            Console.WriteLine(string.Join("" , firstArray));
            Console.WriteLine(string.Join("" , secondArray));
            return;
        }
        else
        {
            Console.WriteLine(string.Join("" , secondArray));
            Console.WriteLine(string.Join("" , firstArray));
        }
      
    }
}

