using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class WeatherInfo
{
    public double AverageTemp { get; set; }

    public string Weather { get; set; }
}
class Weather
{
    static void Main()
    {
        var regex = new Regex(@"(?<city>[A-Z]{2})((?<temp>\d+\.\d+))(?<weather>[a-zA-Z]+)(\|)");

        string input = Console.ReadLine();

        var cities = new Dictionary<string, WeatherInfo>();

        while (input != "end")
        {
            var match = regex.Match(input);

            if (!match.Success)
            {
                input = Console.ReadLine();
                continue;
            }
            var city = match.Groups["city"].Value;
            var temp = double.Parse(match.Groups["temp"].Value);
            var weather = match.Groups["weather"].Value;

            WeatherInfo weatherInfo = new WeatherInfo()
            {
                AverageTemp = temp,
                Weather = weather
            };

            cities[city] = weatherInfo;
            input = Console.ReadLine();
        }

        var result = cities.OrderBy(t => t.Value.AverageTemp);

        foreach (var item in result)
        {
            var city = item.Key;
            var tempWeather = item.Value;
            Console.WriteLine($"{city} => {tempWeather.AverageTemp:f2} => {tempWeather.Weather}");
        }
    }
}

