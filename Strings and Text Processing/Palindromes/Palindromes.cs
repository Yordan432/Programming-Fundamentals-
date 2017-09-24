using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' '  , ',' , '.', '?' , '!'} , StringSplitOptions.RemoveEmptyEntries);

        var palindromes = new List<string>();

        foreach (var item in input)
        {
            var rvs = new string(item.Reverse().ToArray());
            if (item == rvs && !palindromes.Contains(item))
            {
                palindromes.Add(item);
            }
        }
        palindromes = palindromes.OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(", " , palindromes));
    }
}

