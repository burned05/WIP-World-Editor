using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Barrel : Object
    {
        public Barrel(Point _pos = new Point())
            : base("Barrel", _pos)
        {
        }
    }
}
