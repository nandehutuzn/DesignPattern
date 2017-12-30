using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 鹅适配器
    /// </summary>
    class GooseAdapter : IQuackable
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        private Observable _observable;
        public GooseAdapter()
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
