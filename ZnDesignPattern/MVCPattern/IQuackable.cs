using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 鸭子
    /// </summary>
    interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
