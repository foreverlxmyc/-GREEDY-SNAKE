using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Food : GameObject
    {

        public Food(Snake snake)
        {
            RandonPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("★");//◆
        }

        public void RandonPos(Snake snake)
        {
            Random r =new Random();
            int x = r.Next(2, 40 / 2 - 1) * 2;
            int y = r.Next(1, 20-4);

            pos=new Position(x, y);

            if (snake.TheSamePos(pos))
            {
                RandonPos(snake);
            }
        }

    }
}
