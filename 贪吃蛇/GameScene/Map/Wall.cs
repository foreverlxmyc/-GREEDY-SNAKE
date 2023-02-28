using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class Wall : GameObject
    {

        public Wall(int x,int y)
        {
            pos.Y = y;
            pos.X = x;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(pos.X,pos.Y);
            Console.Write("■");
        }
    }
}
