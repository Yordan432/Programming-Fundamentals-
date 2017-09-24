using System;
class BackIn30Minutes
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;
        if(minutes >=60)
        {
            hour += 1;
            minutes -= 60;
        }
        if(hour >=23)
        {
            hour-=24;
            
        }
        Console.WriteLine($"{hour}:{minutes:D2}");
    }
}

