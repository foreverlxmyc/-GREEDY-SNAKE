using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class SnakeBody : GameObject
    {
        E_SnakeType myType;

        public SnakeBody(int x,int y,E_SnakeType type)
        {
            pos.Y = y;
            pos.X = x;
            myType = type;
        }


        public override void Draw()
        {
            Console.ForegroundColor = myType==E_SnakeType.Head?ConsoleColor.Yellow: ConsoleColor.Green;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.Write(myType==E_SnakeType.Head?"●":"■");
        }
    }

    enum E_SnakeType
    {
        Head,
        Body
    }
}
