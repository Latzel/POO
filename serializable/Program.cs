using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

namespace serializable
{
    public class WeatherForecast
    {
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }

    public WeatherForecast(DateTimeOffset Date, int TemperatureCelsius, string Summary)
        {
            this.Date = Date;
            this.TemperatureCelsius = TemperatureCelsius;
            this.Summary = Summary;

        }

    public WeatherForecast()
    {
    }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<WeatherForecast> week = new List<WeatherForecast>();
            WeatherForecast forcast = new WeatherForecast();
            forcast.Date =  DateTimeOffset.Now;
            forcast.TemperatureCelsius = 21;
            forcast.Summary = "Cloudy";
            week.Add(forcast);

            week.Add(new WeatherForecast(new DateTimeOffset(2020,5,18,12,0,0, new TimeSpan(-5,0,0)),18,"sunny" ));

          //  string serial = JsonSerializer.Serialize(week);

           // File.WriteAllText(@"temps.json", serial);

           string jsonString = File.ReadAllText(@"temps.json");
           List<WeatherForecast> file_week = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonString);

            //Console.WriteLine(serial);

            foreach(WeatherForecast w in file_week){
                Console.WriteLine("{0} {1}c {2}", w.Date, w.TemperatureCelsius, w.Summary);
            }
        }
    }
}
