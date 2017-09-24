using System;
using System.Linq;

class MiddleExtract
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine("{ " + numbers[0] + " }");
            }
            else if (numbers.Length % 2 == 0)
            {
                //n/2-1 and n/2
                var middle = numbers[numbers.Length / 2 - 1];
                var midle = numbers[numbers.Length / 2];
                Console.Write("{ " + middle + ", " + midle + " }");
                break;
            }
            else if(numbers.Length % 2 != 0)
            {
                //n/2-1, n/2, n/2+1
                var mid = numbers[numbers.Length / 2 - 1];
                var middle = numbers[numbers.Length / 2];
                var midle = numbers[numbers.Length / 2 + 1];
                Console.Write("{ " + mid + ", " + middle + ", " + midle + " }");
                break;
            }
        }
        Console.WriteLine();
    }

}

