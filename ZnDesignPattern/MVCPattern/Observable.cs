using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_duck));
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
