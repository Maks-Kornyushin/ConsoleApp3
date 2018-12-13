using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Fishes : Animal
    {
        private string Colour { get; set; }
        public Fishes(int wieght, int height, string name, string colour) : base(wieght, height, name)
        {
            Colour = colour;
        }
        public override void Voice()
        {
            Console.WriteLine("I'm a Fish, but I have no voice, soryan");
        }
    }
}

