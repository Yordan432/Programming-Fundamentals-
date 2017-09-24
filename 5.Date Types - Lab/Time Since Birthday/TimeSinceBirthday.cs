using System;

class TimeSinceBirthday
{
    static void Main()
    {
        byte years = byte.Parse(Console.ReadLine());
        int days = years * 365;
        int hour = days * 24;
        int minutes = hour * 60;
        Console.WriteLine($"{years} years = {days} days {hour} hours {minutes} minutes.");

    }
}

