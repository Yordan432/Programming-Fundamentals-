using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class WordCount
{
    static void Main()
    {
        Dictionary<string, int> wordsCnt = new Dictionary<string, int>();
        string[] text = File.ReadAllLines("Input.txt");

        for (int i = 0; i < text.Length; i++)
        {
            var splitWord = text[i].Split(new string[] { "-" , " " , ","  , "?" , "!" , "…" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in splitWord)
            {
                if (!wordsCnt.ContainsKey(item))
                {
                    wordsCnt[splitWord[i]] = 0;
                }
                wordsCnt[splitWord[i]]++;
            }            
        }
        foreach (var item in wordsCnt)
        {
            var key = item.Key;
            var value = item.Value;
            Console.WriteLine($"{key} -> {value}");
        }
    }
}

