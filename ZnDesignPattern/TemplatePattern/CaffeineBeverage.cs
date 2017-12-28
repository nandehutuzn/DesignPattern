using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
