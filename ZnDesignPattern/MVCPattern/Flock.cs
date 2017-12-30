using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 管理一群鸭子
    /// </summary>
    class Flock : IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            _quackers.ForEach(o => o.Quack());
            NotifyObservers();
        }

        private Observable _observable;
        public Flock()
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
