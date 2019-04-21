using System;

namespace ObserverPatternBuiltIn
{
    static class Program
    {
        static void Main()
        {
            WeatherProvider weatherProvider = new WeatherProvider();

            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay();

            heatIndexDisplay.Subscribe(weatherProvider);
            currentConditionDisplay.Subscribe(weatherProvider);

            weatherProvider.SetMeasurements(new WeatherData(80, 65, 30.4f));
            weatherProvider.SetMeasurements(new WeatherData(82, 70, 29.2f));
            currentConditionDisplay.Unsubscribe();
            weatherProvider.SetMeasurements(new WeatherData(78, 90, 29.2f));
            weatherProvider.SetMeasurements(null);

            Console.ReadKey();
        }
    }
}
