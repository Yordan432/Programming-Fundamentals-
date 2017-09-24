using System;
using System.Collections.Generic;
using System.Linq;
class CapitalizeWords
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            var result = CapitalizeWord(input);
            Console.WriteLine(result.Trim());
            input = Console.ReadLine();
        }
    }
    private static string CapitalizeWord(string input)
    {
        string output = " ";
        var tokens = input.Split(new string[] { ".", ",", "... ", "!", " " }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < tokens.Length; i++)
        {
            char[] toCharArr = tokens[i].ToCharArray();
            for (int j = 0; j < toCharArr.Length; j++)
            {
                if (toCharArr[0] >= 'A' && toCharArr[0] <= 'Z')
                {
                    var smallWord = isWordsSmaller(toCharArr);
                    output += smallWord;
                    output += " ";
                    break;
                }
                else
                {
                    toCharArr[0] = char.ToUpper(toCharArr[0]);
                    var CapitalizeWord = new string(toCharArr);
                    var smallWord = isWordsSmaller(toCharArr);
                    output += smallWord;
                    output += " ";
                    break;
                }
            }
        }
        return output;
    }
    private static string isWordsSmaller(char[] toCharArr)
    {
        string output = " ";
        bool isAllWordLower = false;
        for (int i = 1; i < toCharArr.Length; i++)
        {
            if (toCharArr[i] >= 'A' && toCharArr[i] <= 'Z')
            {
               // toCharArr[i] = toCharArr.All(char.ToLower(toCharArr[i]));
                var lowerWord = new string(toCharArr);
                output += lowerWord;
                isAllWordLower = false;     
            }
            else
            {
                isAllWordLower = true;
            }

        }
        if (isAllWordLower)
        {
            return new string(toCharArr);
        }
        else
        {
            return output;
        }    
    }
}

