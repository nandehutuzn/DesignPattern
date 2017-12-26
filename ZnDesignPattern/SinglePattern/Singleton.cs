using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SinglePattern
{
    class Singleton
    {
        private int _count;

        private Singleton() { }

        private static Singleton _instance;
        public static Singleton Instance {
            get
            {
                if (_instance == null)
                {
                    Interlocked.CompareExchange(ref _instance, new Singleton(), null);
                }
                return _instance;
            }
        }

        public void Add()
        {
            for (int i = 0; i < 100; i++)
                Interlocked.Increment(ref _count);
        }

        public int Count { get { return _count; } }
    }
}
