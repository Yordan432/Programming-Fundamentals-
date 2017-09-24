using System;
using System.Collections.Generic;
using System.Linq;
class PizzaIngredients
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int lenght = int.Parse(Console.ReadLine());

        bool isEnd = false;
        List<string> products = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            var lenghtChar = input[i].ToCharArray().Length;
            if (lenghtChar == lenght)
            {
                products.Add(input[i]);
                Console.WriteLine("Adding {0}.", input[i]);
            }
            isEnd = true;
        }
        if (isEnd)
        {
            Console.WriteLine("Made pizza with total of {0} ingredients.", products.Count);
            Console.WriteLine("The ingredients are: {0}.", string.Join(", " , products));

        }

    }
}

