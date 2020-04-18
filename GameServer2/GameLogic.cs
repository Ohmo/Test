using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer2
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
