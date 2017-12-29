using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER, You get two gumballs for your quarter");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);//糖果不足
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count > 0)
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                else
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public void EjectQuarter()//不支持
        {
            Console.WriteLine("alread dispense, no quarter");
        }

        public void InsertQuarter()//不支持
        {
            Console.WriteLine("alread dispense, no quarter");
        }

        public void TurnCrank()//不支持
        {
            Console.WriteLine("alread dispense, no quarter");
        }
    }
}
