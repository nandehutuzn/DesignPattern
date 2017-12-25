using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 手机挂件
    /// </summary>
    class Accessories : Decorator
    {
        public Accessories(Phone phone)
            :base(phone)
        {

        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        private void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有挂件了");
        }
    }
}
