using System;
class CounttheIntegers
{
    static void Main()
    {
        var num = 0;
        while (true)
        {
            try
            {
                int.Parse(Console.ReadLine());
                num++;
            }
            catch (OverflowException)
            {
                break;          
            }
            catch (FormatException)
            {
                break;
            }
        }
        Console.WriteLine(num);
    }
}

