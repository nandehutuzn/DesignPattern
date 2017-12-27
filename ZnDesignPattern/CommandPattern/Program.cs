using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 命令模式    2017/12/27
/// 将“请求”封装成对象，以便使用不同的请求、队列或者日志来参数化其他对象
/// </summary>
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light light1 = new Light("Living Room");
            Light light2 = new Light("Kitchen");
            Stereo stereo1 = new Stereo("Living Room");
            Stereo stereo2 = new Stereo("Kitchen");

            LightOnCommand lightOnCommand1 = new LightOnCommand(light1);
            LightOffCommand lightOffCommand1 = new LightOffCommand(light1);

            LightOnCommand lightOnCommand2 = new LightOnCommand(light2);
            LightOffCommand lightOffCommand2 = new LightOffCommand(light2);

            StereoOnCommand stereoOnCommand1 = new StereoOnCommand(stereo1);
            StereoOffCommand stereoOffCommand1 = new StereoOffCommand(stereo1);

            StereoOnCommand stereoOnCommand2 = new StereoOnCommand(stereo2);
            StereoOffCommand stereoOffCommand2 = new StereoOffCommand(stereo2);

            remoteControl.SetCommand(0, lightOnCommand1, lightOffCommand1);
            remoteControl.SetCommand(1, lightOnCommand2, lightOffCommand2);
            remoteControl.SetCommand(2, stereoOnCommand1, stereoOffCommand1);
            remoteControl.SetCommand(3, stereoOnCommand2, stereoOffCommand2);

            Console.WriteLine(remoteControl);
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(3);

            Console.ReadKey();
        }
    }
}
