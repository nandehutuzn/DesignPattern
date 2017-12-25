using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 装饰抽象类,让装饰完全取代抽象组件
    /// </summary>
    abstract class Decorator : Phone
    {
        private Phone _phone;

        public Decorator(Phone phone)
        {
            _phone = phone;
        }

        public override void Print()
        {
            _phone?.Print();
        }
    }
}
