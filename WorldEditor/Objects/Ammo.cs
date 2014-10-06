using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Ammo : Object
    {
        public Ammo(Point _pos = new Point())
            : base("Ammo", _pos)
        { 
        }
    }
}
