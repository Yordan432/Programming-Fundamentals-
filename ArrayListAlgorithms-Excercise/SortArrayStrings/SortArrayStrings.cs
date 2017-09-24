using System;
using System.Linq;
class SortArrayStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        bool swaped = false;
        do
        {
            swaped = false;
            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i + 1; j < input.Length; j++)
                {
                    var str = string.Compare(input[i], input[j]);
                    if (str == 1)
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                        swaped = true;
                    }
                }
                
            }

       } while (swaped);

        Console.WriteLine(string.Join(" " , input));
    }
}

