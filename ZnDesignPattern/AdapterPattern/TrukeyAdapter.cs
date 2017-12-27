using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class TrukeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TrukeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
