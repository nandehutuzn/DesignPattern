using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 橡皮鸭
    /// </summary>
    class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("RubberDuck Quack");
            NotifyObservers();
        }

        private Observable _observable;
        public RubberDuck()
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
