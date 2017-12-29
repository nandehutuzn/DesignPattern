using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()//不支持
        {
            Console.WriteLine("No quarter");
        }

        public void EjectQuarter()//不支持
        {
            Console.WriteLine("No quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserter 25 quarter");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void TurnCrank()//不支持
        {
            Console.WriteLine("No quarter");
        }
    }
}
