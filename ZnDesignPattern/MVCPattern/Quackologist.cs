using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {

            Console.WriteLine($"\nQuackologist: {duck} just quacked.");
        }
    }
}
