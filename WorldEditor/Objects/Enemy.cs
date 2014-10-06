using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Enemy : Object
    {
        public Enemy(Point _pos = new Point())
            : base("Enemy", _pos)
        {
        }
    }
}
