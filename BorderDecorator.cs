using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget wid) : base(wid) { }

        public void draw()
        {
            Console.WriteLine("I am a " + GetType().Name + " holding a border.");
        }
    }
}
