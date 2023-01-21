using System;
using System.Collections.Generic;
using System.Text;

namespace mygame.Game
{
    public abstract class Entity
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public virtual void Update() 
        { 

        }
        public virtual void Draw() 
        {
            
        }
    }
}
