using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Shotgun : Object
    {
        public Shotgun(Point _pos = new Point())
            : base("Shotgun", _pos)
        {
        }
    }
}
