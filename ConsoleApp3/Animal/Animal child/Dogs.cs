using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Dogs : Animal
    {
        private int Speed { get; set; }
        public Dogs (int wieght, int height, string name, int speed) : base(wieght, height, name)
        {
            Speed = speed;
        }
        public override void Voice()
        {
            Console.WriteLine("I'm a dog. Bark Bark" +
                "\n My weight is " + Weight + " kg" + 
                "\n My height is " + Height + " sm" + 
                "\n My name is " + Name +
                "\n My speed is " + Speed + " km/h" + "\n");
        }
    }
}

