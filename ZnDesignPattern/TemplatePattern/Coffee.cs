using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Coffee AddCondiments");
        }

        protected override void Brew()
        {
            Console.WriteLine("Coffee Brew");
        }
    }
}
