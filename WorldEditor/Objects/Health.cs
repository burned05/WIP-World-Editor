using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Health : Object
    {
        public Health(Point _pos = new Point())
            : base("Health", _pos)
        {
        }
    }
}
