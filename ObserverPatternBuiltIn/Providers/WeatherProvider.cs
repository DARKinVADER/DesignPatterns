using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltIn
{
    class WeatherProvider : IObservable<WeatherData>
    {
        readonly List<IObserver<WeatherData>> observers;

        public WeatherProvider()
        {
            observers = new List<IObserver<WeatherData>>();
        }
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        public void SetMeasurements(WeatherData weatherData)
        {
            if (weatherData == null)
            {
                foreach (var observer in observers.ToArray())
                {
                    if (observer != null)
                    {
                        observer.OnCompleted();
                    }
                }
                observers.Clear();
            }
            else
            {
                foreach (var observer in observers.ToArray())
                {
                    observer.OnNext(weatherData);
                }
            }
        }
    }
}
