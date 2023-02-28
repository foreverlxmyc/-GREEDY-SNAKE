using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Snake : IDraw
    {
        SnakeBody[] bodies;

        int snakeIndex = 0;

        E_Direction mDir;

        public Snake(int x,int y)
        {
            bodies = new SnakeBody[200];

            bodies[0] = new SnakeBody(x, y, E_SnakeType.Head);
            snakeIndex = 1;
        }


        public void Draw()
        {
            for(int i = 0; i < snakeIndex; i++)
            {
                bodies[i].Draw();
            }

        }

        public void Move()
        {
            SnakeBody last = bodies[snakeIndex - 1];
            Console.SetCursorPosition(last.pos.X,last.pos.Y);
            Console.Write("  ");

            for (int i = snakeIndex-1; i > 0 ; i--)
            {
                bodies[i].pos = bodies[i - 1].pos;
            }

            switch (mDir)
            {
                case E_Direction.Up:
                    bodies[0].pos.Y--;
                    break;
                case E_Direction.Down:
                    bodies[0].pos.Y++;
                    break;
                case E_Direction.Left:
                    bodies[0].pos.X-=2;
                    break;
                case E_Direction.Right:
                    bodies[0].pos.X+=2;
                    break;
                
            }
        }

        public void ChangeDir(E_Direction dir)
        {
            if (snakeIndex > 1 && (mDir == E_Direction.Left && dir == E_Direction.Right) ||
                (mDir == E_Direction.Right && dir == E_Direction.Left) ||
                (mDir == E_Direction.Up && dir == E_Direction.Down) ||
                (mDir == E_Direction.Down && dir == E_Direction.Up))
            {
                return;
            }

            mDir = dir;
        }

        public bool TheSamePos(Position pos)
        {
            for (int i = 0; i < snakeIndex; i++)
            {
                if (bodies[i].pos == pos)
                {
                    return true;
                }
            }
            return false;

        }


        public void EatFood(Food food)
        {
            if (bodies[0].pos == food.pos)
            {
                food.RandonPos(this);
                bodies[snakeIndex] = new SnakeBody(0, 0, E_SnakeType.Body);
                snakeIndex++;

            }
        }

        public bool IsDead(Map map)
        {
            for (int i = 1; i < snakeIndex; i++)
            {
                if (bodies[0].pos == bodies[i].pos)
                {
                    return true;
                }
            }
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodies[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }
            return false;

        }


    }

    enum E_Direction
    {
        Up,
        Down,
        Left,
        Right
    }

}
