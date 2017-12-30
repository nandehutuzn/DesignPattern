using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 鸭子装饰者，给鸭子增加新功能（统计）
    /// </summary>
    class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int _NumberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _NumberOfQuacks++;
            _duck.Quack();
            NotifyObservers();
        }

        public static int NumberOfQuacks { get { return _NumberOfQuacks; } }

        private Observable _observable;

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
