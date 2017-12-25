using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 贴膜，具体装饰者
    /// </summary>
    class Sticker : Decorator
    {
        public Sticker(Phone phone)
            :base(phone)
        {

        }

        public override void Print()
        {
            base.Print();

            AddSticker();
        }

        private void AddSticker()
        {
            Console.WriteLine("现在苹果手机贴膜了");
        }
    }
}
