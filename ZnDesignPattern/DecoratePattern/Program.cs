using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 装饰者模式
/// 动态地将责任附加到对象上，若要扩展功能，装饰者提供了比继承更有弹性的替代方案
/// </summary>
namespace DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //买了个新手机
            Phone phone = new ApplePhone();

            //想贴膜
            Decorator applePhoneWithSticker = new Sticker(phone);
            applePhoneWithSticker.Print();
            Console.WriteLine("-------------------------\n");

            //还想挂件
            Decorator applePhoneAccessories = new Accessories(phone);
            applePhoneAccessories.Print();
            Console.WriteLine("-----------------------\n");

            //想同时有贴膜和手机挂件
            Sticker sticker = new Sticker(phone);
            Accessories applePhoneWithAccessoriesAnSticker = new Accessories(sticker);
            applePhoneWithAccessoriesAnSticker.Print();
            Console.WriteLine("------------------------------\n");

            Console.ReadKey();

        }
    }
}
