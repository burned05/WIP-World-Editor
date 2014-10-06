using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Boss : Object
    {
        public Boss(Point _pos = new Point())
            : base("Boss", _pos)
        {
        }
    }
}
