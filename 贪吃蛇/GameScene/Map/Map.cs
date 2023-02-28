using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Map : IDraw
    {
        public Wall[] walls;

        public Map()
        {
            walls = new Wall[40 + (20 - 3) * 2];

            int index = 0;
            for(int i = 0; i < 40; i+=2)
            {
                walls[index] = new Wall(i, 0);
                index++;
                walls[index] = new Wall(i, 20 - 2);
                index++;
            }
            for (int i = 1; i < 20-2; i++)
            {
                walls[index] = new Wall(0, i);
                index++;
                walls[index] = new Wall(40-2, i);
                index++;
            }
        }


        public void Draw()
        {
            for(int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw();
            }
        }
    }
}
