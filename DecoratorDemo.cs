using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    internal class DecoratorDemo
    {
        static void Main(string[] args)
        {
            TextField t = new TextField(64, 64);
            t.draw();

            BorderDecorator border = new BorderDecorator(t);
            border.draw();

            ScrollDecorator scroll = new ScrollDecorator(t);
            scroll.draw();

            PictureDecorator picture = new PictureDecorator(t);
            picture.draw();
        }
    }
}
