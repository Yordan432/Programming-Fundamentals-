using System;
using System.Collections.Generic;
using System.Linq;
class ShortWordsSorted
{
    static void Main()
    {
        //. , : ; ( ) [ ] " ' \ / ! ? (space).
        List<string> words = Console.ReadLine().ToLower().
            Split(new char[] {'.' , ',' , ':' , ';' , '(' , ')' , '[' , ']' , '\'' , '\\' , '/' , '!' , '?' , ' '} , StringSplitOptions.RemoveEmptyEntries).ToList();

        var lenght = words.Where(x => x.Length < 5);
        var sorted = lenght.OrderBy(x => x);
        var distinct = sorted.Distinct();

        List<string> resultList = new List<string>();

        foreach (var item in distinct)
        {
            resultList.Add(item);
        }
        Console.WriteLine(string.Join(", " , resultList));
    }
}

