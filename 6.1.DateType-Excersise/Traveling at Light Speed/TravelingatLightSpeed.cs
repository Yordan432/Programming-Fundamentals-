using System;
using System.Globalization;

class TravelingAtLightSpeed
{
    static void Main()
    {
        decimal lightSpeed = decimal.Parse(Console.ReadLine());

        decimal lightYearsKm = 9450000000000M;
        decimal speedOfLight = 300000M;

        decimal total = (lightYearsKm / speedOfLight) * lightSpeed;
        TimeSpan diff = TimeSpan.FromSeconds((double)total);
        string formated = string.Format(CultureInfo.CurrentCulture,
            "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
           diff.Days / 7,
           diff.Days % 7,
           diff.Hours,
           diff.Minutes,
           diff.Seconds);
        Console.WriteLine(formated);
    }
}

