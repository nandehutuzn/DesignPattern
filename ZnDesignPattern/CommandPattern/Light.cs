using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Light
    {
        public string Name { get; set; }

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} Light On");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} Light Off");
        }
    }
}
