using ObserverPattern_WeatherData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherData.Displays
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject weatherData;
        private float temperature;
        private float humidity;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
