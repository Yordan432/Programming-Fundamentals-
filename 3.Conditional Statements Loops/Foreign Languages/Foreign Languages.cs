using System;
class ForeignLanguages
{
    static void Main()
    {
        string language = Console.ReadLine();
        string result = "";

        if (language == "USA" || language == "England")
        {
            result = "English";
        }
        else if(language == "Spain" || language == "Argentina" || language == "Mexico")
        {
            result = "Spanish";
        }
        else
        {
            result = "unknown";
        }
        Console.WriteLine(result);
    }
}

