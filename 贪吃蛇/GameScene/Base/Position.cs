using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    struct Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            X = x; Y = y; 
        }

        public static bool operator ==(Position p1, Position p2)
        {
            if(p1.X == p2.X && p1.Y == p2.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
            {
                return false;
            }
            return true;
        }
    }
}
