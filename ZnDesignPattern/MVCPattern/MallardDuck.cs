using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 绿头鸭
    /// </summary>
    class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("MallardDuck  Quack");
            NotifyObservers();
        }

        private Observable _observable;
        public MallardDuck()
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
