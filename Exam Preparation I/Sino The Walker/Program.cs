using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var hours = DateTime.ParseExact(time, "H:m:s", CultureInfo.InvariantCulture);
            var numberStep = long.Parse(Console.ReadLine());
            var timeStep = long.Parse(Console.ReadLine());
            numberStep *= timeStep;         
            var day = 24 * 60 * 60;
            numberStep = numberStep % day;
            var addStep = hours.AddSeconds(numberStep);
            Console.WriteLine("Time Arrival: {0}" , addStep.TimeOfDay);
        }
    }
}
