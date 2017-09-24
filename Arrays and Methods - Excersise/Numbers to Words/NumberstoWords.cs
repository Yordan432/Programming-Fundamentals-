using System;
class NumberstoWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            int[] digits = new int[currentNumber];
            if (currentNumber > 999)
            {
                Console.WriteLine("too large");
            }
            else if (currentNumber < -999)
            {

            }
            else if(currentNumber < 0)
            {
                //minus
            }
            else if (digits.Length < 3)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}

