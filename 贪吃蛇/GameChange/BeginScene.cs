using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class BeginScene : BaseScene
    {

        public BeginScene()
        {
            title = "贪吃蛇";
            select = "开始游戏";
        }



        public override void DoJ()
        {
            if (index == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
