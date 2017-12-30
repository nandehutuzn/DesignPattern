using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 鸭子观察器
    /// </summary>
    interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
