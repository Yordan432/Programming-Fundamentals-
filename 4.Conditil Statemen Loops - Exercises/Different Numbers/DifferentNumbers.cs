using System;

class DifferentNumbers
{
    static void Main()
    {
        var min = int.Parse(Console.ReadLine());
        var max = int.Parse(Console.ReadLine());

        for (int first = min; first <=max; first++)
        {
            for (int last = min; last <=max; last++)
            {
                for (int third = min; third <=max; third++)
                {
                    for (int fourth = min; fourth <=max; fourth++)
                    {
                        for (int fifth = min; fifth <=max; fifth++)
                        {
                            if (first < last && last < third && third < fourth && fourth < fifth)
                            {
                                Console.WriteLine($"{first} {last} {third} {fourth} {fifth}");
                            }
                        }

                    }
                }
            }          
        }
        if (max - min < 4)
        {
            Console.WriteLine("No");
        }
    }
}

