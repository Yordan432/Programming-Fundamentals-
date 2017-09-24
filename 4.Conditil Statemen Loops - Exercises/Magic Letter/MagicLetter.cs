using System;
class MagicLetter
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        string thirdLetter = Console.ReadLine();

        string result = "";

        for (char letter1 = firstLetter; letter1 <= secondLetter; letter1++)
        {
            for (char letter2 = firstLetter; letter2 <= secondLetter; letter2++)
            {
                for (char letter3 = firstLetter; letter3 <= secondLetter; letter3++)
                {
                    result = $"{letter1}{letter2}{letter3}";
                    if (!result.Contains(thirdLetter))
                    {
                        Console.Write(result + " ");
                    }
                }
            }   
        }
        Console.WriteLine();
    }
}

