using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 主题
    /// </summary>
    interface ISubject
    {
        /// <summary>
        /// 注册成为观察者
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);

        /// <summary>
        /// 取消注册
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        /// <summary>
        /// 发送通知
        /// </summary>
        void NotifyObservers();
    }
}
