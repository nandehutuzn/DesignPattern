using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()//不支持
        {
            Console.WriteLine("No gumball");
        }

        public void EjectQuarter()//不支持
        {
            Console.WriteLine("No gumball");
        }

        public void InsertQuarter()//不支持
        {
            Console.WriteLine("No gumball");
        }

        public void TurnCrank()//不支持
        {
            Console.WriteLine("No gumball");
        }
    }
}
