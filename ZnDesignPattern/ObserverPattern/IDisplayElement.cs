using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者收到通知后需要触发的动作
    /// </summary>
    interface IDisplayElement
    {
        void Display();
    }
}
