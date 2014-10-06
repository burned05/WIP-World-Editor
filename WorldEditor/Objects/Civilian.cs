using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Civilian : Object
    {
        public Civilian(Point _pos = new Point())
            : base("Civilian", _pos)
        {
        }
    }
}
