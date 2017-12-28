using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Tea AddCondiments");
        }

        protected override void Brew()
        {
            Console.WriteLine("Tea Brew ...");
        }
    }
}
