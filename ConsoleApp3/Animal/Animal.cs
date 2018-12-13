using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Animal
    {
        protected int Weight { get; set; }
        protected int Height { get; set; }
        protected string Name { get; set; }
        public abstract void Voice();
        
        public Animal(int wieght, int height, string name)
        {
            Weight = wieght;
            Height = height;
            Name = name;
        }
    }
}
