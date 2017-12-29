using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Duck
    {
        public Duck() { }

        protected IFlyBehavior _flyBehavior;  
        protected IQuackBehavior _quackBehavior;

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }

        public void PerformFly()  //会改变的接口封装
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()  //不变的固定
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public abstract void Display();
    }
}
