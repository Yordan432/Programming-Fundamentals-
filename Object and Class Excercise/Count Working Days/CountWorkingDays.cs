using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class CountWorkingDays
{
    static void Main()
    {
       var dateHolidays = new string[]
        {
            "01-01",
            "03-03",
            "01-05",
            "06-05",
            "24-05",
            "06-09",
            "22-09",
            "01-11",
            "24-12",
            "25-12",
            "26-12"
        }.Select(x => DateTime.ParseExact(x, "dd-MM" , CultureInfo.InvariantCulture)).ToArray();

        string firstDate = Console.ReadLine();
        DateTime firstDateTime = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        string endDate = Console.ReadLine();
        DateTime endDateTime = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        int countWorkDays = 0;
        for (DateTime date = firstDateTime; date <= endDateTime; date = date.AddDays(1))
        {
            var isDaySundayOrSaturday = date.DayOfWeek == DayOfWeek.Saturday ||date.DayOfWeek == DayOfWeek.Sunday;

            var isHolidays = dateHolidays.Any(d => d.Day == date.Day && d.Month == date.Month);

            if (!(isDaySundayOrSaturday || isHolidays))
            {
                countWorkDays++;
            }           
        }
        Console.WriteLine(countWorkDays);
    }
}

