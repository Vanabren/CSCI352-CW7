using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public abstract class Decorator : IWidget
    {
        protected IWidget wid;

        public Decorator(IWidget w)
        {
            wid = w;
        }

        public void draw()
        {
            wid.draw();
        }
    }
}
