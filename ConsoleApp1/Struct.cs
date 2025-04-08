using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Position a, Position b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Position a, Position b)
        {
            return a.x != b.x || a.y != b.y;
        }
    }
}
