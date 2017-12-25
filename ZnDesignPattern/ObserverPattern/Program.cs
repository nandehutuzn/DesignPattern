using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 观察者模式  
/// 定义了对象之间一对多依赖，这样一来，当一个对象改变状态时，它的所有依赖者都会收到通知并自动更新
/// </summary>
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statistics = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(80f, 65f, 30.4f);
            weatherData.SetMeasurements(90f, 70f, 34.4f);
            weatherData.SetMeasurements(85f, 60f, 29.4f);

            Console.ReadKey();
        }
    }
}
