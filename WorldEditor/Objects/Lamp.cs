using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Lamp
        : Object
    {
        public Lamp(Point _pos = new Point())
            : base("Lamp", _pos)
        {
        }
    }
}
