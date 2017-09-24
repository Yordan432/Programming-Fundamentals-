using System;

class GreaterofTwoValues
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (input == "int")
        {
            var firstNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());

            var result = GetMax(firstNum, lastNum);
            Console.WriteLine(result);
        }
        else if(input == "string")
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();

            var result = GetMax(first, last);
            Console.WriteLine(result);
        }
        else if(input == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            var result = GetMax(first, last);
            Console.WriteLine(result);
        }
    }
    static int GetMax(int firstNumber, int lastNumber)
    {
        if (firstNumber > lastNumber)
        {
            return firstNumber;
        }
        return lastNumber;
    }

    static string GetMax(string firstText, string lastText)
    {
        if (firstText.CompareTo(lastText) >= 0)
        {
            return firstText;
        }
        return lastText;
    }

    static char GetMax(char first, char last)
    {
        if (first > last)
        {
            return first;
        }
        return last;
    }
}

