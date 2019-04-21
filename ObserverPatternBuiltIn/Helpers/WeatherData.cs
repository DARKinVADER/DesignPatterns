using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternBuiltIn
{
    class WeatherData
    {
        public float Temperature { get; }
        public float Pressure { get;  }
        public float Humidity { get;  }

        public WeatherData(float temperature, float pressure, float humidity)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
        }
    }
}
