using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class EndScene : BaseScene
    {
        public EndScene()
        {
            title = "游戏结束";
            select = "重新开始";
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
