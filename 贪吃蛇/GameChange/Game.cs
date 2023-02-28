using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class Game
    {
        int w = 40;
        int h = 20;
        static ISceneUpdate myScene;

        public Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }

        public void Start()
        {
            ChangeScene(E_SceneType.Begin);
            while (true)
            {
                if (myScene != null)
                    myScene.Update();
            }
        }

        public static void ChangeScene(E_SceneType type)
        {
            Console.Clear();
            switch (type)
            {
                case E_SceneType.Begin:
                    myScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    myScene = new GameScene();
                    break;
                case E_SceneType.End:
                    myScene = new EndScene();
                    break;
            }
        }
    }
    enum E_SceneType
    {
        Begin,
        Game,
        End
    }
}
