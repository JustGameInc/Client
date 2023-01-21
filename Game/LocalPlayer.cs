using System;
using System.Collections.Generic;
using System.Text;

namespace mygame.Game
{
    public class LocalPlayer : Entity
    {
        public LocalPlayer()
        {
            Health= 100;
            Speed= 50;
        }

        public override void Draw()
        {
            base.Draw();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
