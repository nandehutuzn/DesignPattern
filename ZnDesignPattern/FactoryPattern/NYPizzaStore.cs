using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();
            else if (type.Equals("chicago"))
                return new ChicagoStyleCheesePizza();
            else
                return null;
        }
    }
}
