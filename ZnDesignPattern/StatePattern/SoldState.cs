using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();//发放糖果
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
                Console.WriteLine("Oops, out of gumballs");
            }
        }

        public void EjectQuarter()//不支持的动作
        {
            Console.WriteLine("Sorry,you already turned the crank");
        }

        public void InsertQuarter()//不支持的动作
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()//不支持的动作
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
    }
}
