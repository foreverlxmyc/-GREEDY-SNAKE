using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    abstract class BaseScene : ISceneUpdate
    {
        protected string title, select;
        protected int index = 0;


        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40 / 2 - title.Length, 5);
            Console.Write(title);

            Console.ForegroundColor = index == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.SetCursorPosition(40 / 2 - select.Length, 8);
            Console.Write(select);

            Console.ForegroundColor = index == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.SetCursorPosition(40 / 2 - 4, 10);
            Console.Write("结束游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    index = 0;
                    break;
                case ConsoleKey.S:
                    index = 1;
                    break;
                case ConsoleKey.J:
                    DoJ();
                    break;
            }

        }

        public abstract void DoJ();
    }
}
