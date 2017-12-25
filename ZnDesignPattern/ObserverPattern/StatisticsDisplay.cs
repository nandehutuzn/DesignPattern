using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float _humidity;
        private float _pressure;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay Humidity :{_humidity}   Pressure: {_pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
