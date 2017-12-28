using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class CaffeineBeverageWithHook
    {
        /// <summary>
        /// 钩子，子类可覆盖
        /// </summary>
        protected virtual bool CustomerWantsCondiments ()
        {
            return true;
        }

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
                AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
