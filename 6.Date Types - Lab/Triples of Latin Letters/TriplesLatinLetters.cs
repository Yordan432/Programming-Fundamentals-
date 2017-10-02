using System;
class TriplesLatinLetters
{
    static void Main()
    {
        int letter = int.Parse(Console.ReadLine());
        for (int letter1 = 0; letter1 <letter; letter1++)
        {
            for (int letter2 = 0; letter2 <letter; letter2++)
            {
                for (int letter3 = 0; letter3 <letter; letter3++)
                {
                    var firstLetter = (char)(letter1 + 'a');
                    var secondLetter = (char)(letter2 + 'a');
                    var thirdLetter = (char)(letter3 + 'a');
                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                }
            }
        }
    }
}

