using System;

class TrickyStrings
{
    static void Main()
    {

        string delimiter = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string currentText = string.Empty;

        for (int i = 0; i < n; i++)
        {
            var readWord = Console.ReadLine();
            currentText = $"{currentText}{readWord}{delimiter}";
        }
        string removeLastChar = currentText.Remove(currentText.Length - delimiter.Length, delimiter.Length);
        Console.WriteLine($"{removeLastChar}");
    }
}

