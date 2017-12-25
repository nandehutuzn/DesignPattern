using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者
    /// </summary>
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
