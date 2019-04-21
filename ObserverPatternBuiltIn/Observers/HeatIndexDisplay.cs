using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltIn
{
    class HeatIndexDisplay : IObserver<WeatherData>
    {
        private IDisposable unsubscriber;
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
            float heatIndex = computeHeatIndex(value.Temperature, value.Humidity);

            Console.WriteLine($"Heat index is {heatIndex}");
        }
        private float ComputeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }
    }
}
