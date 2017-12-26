using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 单件模式
/// </summary>
namespace SinglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100, o => Singleton.Instance.Add());

            Console.WriteLine(Singleton.Instance.Count);
            Console.ReadKey();
        }
    }
}
