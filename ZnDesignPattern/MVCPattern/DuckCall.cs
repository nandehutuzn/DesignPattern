using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 鸣鸭器
    /// </summary>
    class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("DuckCall  Kwak");
            NotifyObservers();
        }

        private Observable _observable;
        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }


        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
