using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;  
        public GameScene()
        {
            map = new Map();
            snake = new Snake(20,10);
            food=new Food(snake);
        }

        public void Update()
        {
            if(Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_Direction.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_Direction.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_Direction.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_Direction.Right);
                        break;
                }
            }

            Thread.Sleep(300);

            food.Draw();
            snake.Move();
            map.Draw();
            snake.Draw();
            snake.EatFood(food);

            if (snake.IsDead(map))
                Game.ChangeScene(E_SceneType.End);
        }
    }
}
