using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _state = _soldOutState;
            _count = numberGumballs;
            if (numberGumballs > 0)
                _state = _noQuarterState;
        }

        public IState SoldOutState { get { return _soldOutState; } }
        public IState NoQuarterState { get { return _noQuarterState; } }
        public IState HasQuarterState { get { return _hasQuarterState; } }
        public IState SoldState { get { return _soldState; } }
        public IState WinnerState { get { return _winnerState; } }
        public int Count { get { return _count; } }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        private void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
                _count--;
        }

        public void ReFill(int gumballs)
        {
            _count += gumballs;
            _state = _noQuarterState;
        }
    }
}
