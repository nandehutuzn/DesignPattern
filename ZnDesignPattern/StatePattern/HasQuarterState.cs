using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()  //不支持的动作
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter() //退出顾客的钱
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()//不支持的动作
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }
    }
}
