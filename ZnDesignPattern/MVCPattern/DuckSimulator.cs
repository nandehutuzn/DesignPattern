using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class DuckSimulator
    {
        private AbstractDuckFactory _duckFactory;
        private IQuackable _mallardDuck;
        private IQuackable _redheadDuck;
        private IQuackable _duckCall;
        private IQuackable _rubberDuck;
        private IQuackable _gooseDuck;//经过适配器包装的鹅

        public DuckSimulator(AbstractDuckFactory duckFactory)
        {
            _duckFactory = duckFactory;
            _mallardDuck = _duckFactory.CreateMallardDuck();
            _redheadDuck = _duckFactory.CreateRedheadDuck();
            _duckCall = _duckFactory.CreateDuckCall();
            _rubberDuck = _duckFactory.CreateRubberDuck();
            _gooseDuck = new GooseAdapter(new Goose());
        }

        public void Simulate()
        {
            Console.WriteLine("\n Duck Simlator");
            Simulate(_mallardDuck);
            Simulate(_redheadDuck);
            Simulate(_duckCall);
            Simulate(_rubberDuck);
            Simulate(_gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} Times");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
