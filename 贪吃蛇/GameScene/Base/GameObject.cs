﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    abstract class GameObject : IDraw
    {
        public Position pos;

        public abstract void Draw();
    }
}
