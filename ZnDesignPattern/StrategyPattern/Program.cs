using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 策略模式 ----2017/12/29
/// 定义了算法族，分别封装起来，让它们之间可以相互替换，此模式让算法的变化独立于使用算法的客户
/// </summary>
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck modelDuck = new ModeDuck();

            modelDuck.PerformFly();
            modelDuck.PerformQuack();
            modelDuck.Display();

            Console.ReadKey();
        }
    }
}
