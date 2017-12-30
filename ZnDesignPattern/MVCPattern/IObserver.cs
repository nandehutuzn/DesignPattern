using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
