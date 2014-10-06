using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Wardrobe
        : Object
    {
        public Wardrobe(Point _pos = new Point())
            : base("Ammo", _pos)
        {
        }
    }
}
