using System;
using System.Collections.Generic;
using System.Linq;
class ChangeList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string[] input = Console.ReadLine().Split(' ');
        while (!(input[0] != "Odd") || input[0] != "Even")
        {
            if (input[0] == "Delete")
            {
                var elementForRemove = int.Parse(input[1]);
                numbers.RemoveAll(x => x == elementForRemove);
            }
            else if(input[0] == "Insert")
            {
                var currenetElement = int.Parse(input[1]);
                var indexInsert = int.Parse(input[2]);
                numbers.Insert(indexInsert, currenetElement);
            }
            input = Console.ReadLine().Split(' ');
            if (input[0] == "Odd")
            {   
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");                 
                    }              
                }
                Console.WriteLine();
                return;
            }
            if (input[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine();
                return;                    
            }
        }
        Console.WriteLine();
    }
}

