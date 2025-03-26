using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        public Enemy (string name)
        {
            this.name = name;
            this.health = 100;
            this.shield = 0;
        }
    }
}