using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltIn
{
    class Unsubscriber : IDisposable
    {
        private List<IObserver<WeatherData>> _observers;
        private IObserver<WeatherData> _observer;
        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observer = observer;
            _observers = observers;
        }
        public void Dispose()
        {
            if (!(_observer == null))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
