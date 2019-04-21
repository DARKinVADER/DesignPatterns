using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_WeatherData.Interfaces
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
