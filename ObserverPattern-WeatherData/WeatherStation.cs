using ObserverPattern_WeatherData.Displays;
using System;

namespace ObserverPattern_WeatherData
{
    static class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            HeatIndexDisplay heatIndex = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
