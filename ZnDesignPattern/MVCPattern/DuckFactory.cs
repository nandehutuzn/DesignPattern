using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 生产鸭子具体工厂，不用装饰器
    /// </summary>
    class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
