using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltIn
{
    class CurrentConditionDisplay : IObserver<WeatherData>
    {
        private IDisposable unsubscriber;
        //private bool first = true;
        //private WeatherData last;

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
        public void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"Current conditions: {value.Temperature}C degrees and {value.Humidity}% humidity");
        }
    }
}
