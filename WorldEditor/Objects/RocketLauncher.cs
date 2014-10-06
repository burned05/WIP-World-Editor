using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class RocketLauncher : Object
    {
        public RocketLauncher(Point _pos = new Point())
            : base("Rocket Launcher", _pos)
        {
        }
    }
}
