using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjXNAGame
{
    class ZombieHigh:theGame
    {
        sprite Deadman1;
        public void DeadMan()
        {
            sprite Deadman1 = new sprite(this, "Deadman-1", 31, 64, 0, 0);
            Deadman1.setVelocity(0, 0);

        }
        public override void gameIni()
        {
            
            DeadMan();
        }
        public override void gameLogic()
        {

        }
        public override void gameRender()
        {
            Deadman1.draw();
        }

    }
}
