using ObserverPattern_WeatherData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherData
{
    class WeatherData : ISubject
    {
        private readonly IList<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float pressure;
        private float humidity;

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
