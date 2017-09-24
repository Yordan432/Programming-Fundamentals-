using System;
using System.Globalization;

class DayofWeek
{
    static void Main()
    {
        string date = Console.ReadLine();
        var dateTime = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

        var dayOfWeek = dateTime.DayOfWeek;
        Console.WriteLine(dayOfWeek);
    }
}

