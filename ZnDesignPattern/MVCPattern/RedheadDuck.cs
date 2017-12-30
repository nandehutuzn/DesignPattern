using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 红头鸭
    /// </summary>
    class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("RedheadDuck Quack");
            NotifyObservers();
        }

        private Observable _observable;
        public RedheadDuck()
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
