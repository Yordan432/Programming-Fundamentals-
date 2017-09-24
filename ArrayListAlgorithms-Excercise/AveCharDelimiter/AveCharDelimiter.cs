using System;
using System.Linq;

class AveCharDelimiter
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split(' ').ToArray();

        int sum = 0;
        int counter = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            foreach (var item in elements[i])
            {
                sum += item;
                counter++;
            }
        }
        double average = Math.Floor((double)sum / counter);
        var delimeter = (char)average;
        Console.WriteLine(string.Join(delimeter.ToString().ToUpper() , elements));
    }
}
