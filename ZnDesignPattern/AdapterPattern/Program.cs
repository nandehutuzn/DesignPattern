using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 适配器模式  2017/12/27
/// 将一个类的接口，转换成客户期望的另一个接口，适配器让原本接口不兼容的类可以合作无间
/// </summary>
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TrukeyAdapter(turkey);

            duck.Fly();
            duck.Quack();

            turkey.Fly();
            turkey.Gobble();

            turkeyAdapter.Fly();
            turkeyAdapter.Quack();

            Console.ReadKey();
        }
    }
}
