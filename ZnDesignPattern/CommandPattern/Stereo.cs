using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Stereo
    {
        public string Name { get; set; }

        public Stereo(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} Stereo On");
        }

        public void SetCD()
        {
            Console.WriteLine($"{Name} Stereo SetCD");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{Name} Stereo SetVolume {volume}");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} Stereo Off");
        }
    }
}
