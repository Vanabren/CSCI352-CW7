using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class PictureDecorator : Decorator
    {
        public PictureDecorator(IWidget widget) : base(widget) { }

        public void draw() 
        {
            Console.WriteLine("I am a " + GetType().Name + " holding a picture.");
        }
    }
}
