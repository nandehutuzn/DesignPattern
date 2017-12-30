using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// MVC模式 ---- 2017/12/30
/// </summary>
namespace MVCPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            DuckSimulator simluator = new DuckSimulator(duckFactory);
            simluator.Simulate();

            Console.ReadKey();
        }
    }
}
