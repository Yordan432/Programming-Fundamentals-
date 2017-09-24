using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Placeholders
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            var elements = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var words = elements[0].Trim();
            var replaceWord = elements[1].Trim().Split(new char[] { ',', ' ' } , StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < replaceWord.Length; i++)
            {
                var placeholder = "{" + i + "}";
                words = words.Replace(placeholder, replaceWord[i]);
            }
            Console.WriteLine(words);

            input = Console.ReadLine();
        }
    }
}

