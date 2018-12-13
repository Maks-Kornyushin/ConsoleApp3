using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cats : Animal
        
    {
        private string Type { get; set; }
        public Cats(int wieght, int height, string name, string type) : base(wieght, height, name)
        {
            Type = type;
        }
        public override void Voice()
        {
            Console.WriteLine("I'm a Cat. Meow Meow" + 
                "\n My weight is " + Weight + " kg" +
                "\n My height is " + Height + " sm" +
                "\n My name is " + Name + 
                "\n And my type is " + Type + "\n");
        }
    }
}
