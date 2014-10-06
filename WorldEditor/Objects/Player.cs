using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Player : Object
    {
        public Player(Point _pos = new Point())
            : base("Player", _pos)
        {
        }
    }
}
