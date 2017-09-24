using System;
using System.Collections.Generic;
using System.Linq;
class DayOfWeek
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        string[] dayOfWeeks = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        //                         1         2            3          4           5          6         7
        //                         0         1            2          3           4          5         6
        for (int i = 1; i <=dayOfWeeks.Length; i++)
        {
            if (dayOfWeek == i)
            {
                Console.WriteLine(dayOfWeeks[i -1]);
                break;
            }
            else if(dayOfWeek > dayOfWeeks.Length || dayOfWeek == 0)
            {
                Console.WriteLine("invalid day");
                break;
            }
        }
    }
}

