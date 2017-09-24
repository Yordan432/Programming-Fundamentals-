using System;
using System.Linq;

class ArraySymmetry
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();
        string yes = string.Empty;
        string no = string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[0] == words[words.Length - 1])
            {
                Console.WriteLine(yes =  "Yes");
                break;
            }
            else
            {
                Console.WriteLine(no = "No");
                break;
            }
        }
    }
}

