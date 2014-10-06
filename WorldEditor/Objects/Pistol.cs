using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Pistol : Object
    {
        public Pistol(Point _pos = new Point())
            : base("Pistol", _pos)
        {
        }
    }
}
