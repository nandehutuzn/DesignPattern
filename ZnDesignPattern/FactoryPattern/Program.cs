using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 工厂方法模式   
/// 通过让子类决定该创建的对象是什么，来达到将对象创建的过程封装的目的
/// 
/// 抽象工厂模式
/// 提供一个接口，用于创建相关或依赖对象的家族，而不需要明确指定具体类
/// 提供一个抽象接口用来创建一个家族产品，再将此接口传入具体产品中
/// </summary>
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore(); //这里可以创建多个工厂,略
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
            pizza = nyStore.OrderPizza("chicago");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            Console.ReadKey();
        }
    }
}
