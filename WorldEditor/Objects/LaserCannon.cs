using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class LaserCannon : Object
    {
        public LaserCannon(Point _pos = new Point())
            : base("Laser Cannon", _pos)
        {
        }
    }
}
