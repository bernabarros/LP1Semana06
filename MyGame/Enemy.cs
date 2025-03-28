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
        static int power_pickups;
        public Enemy ()
        {
            this.name = SetName();
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            power_pickups = 0;
        }
        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public static int GetPickups()
        {
            return power_pickups;
        }

        public string SetName()
        {
            string newname = Console.ReadLine();
            newname = newname.Remove(8);
            name = newname;
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
            Console.WriteLine($"Shield: {shield}");
            Console.WriteLine($"Health: {health}");
        }
        public void PickupPowerUp(PowerUp power_up, float power_value)
        {
            if(power_up == PowerUp.Health)
            {
                health += power_value;
                if(health > 100) health = 100;
                Console.WriteLine($"Health: {health}");
            }
            else if(power_up == PowerUp.Shield)
            {
                shield += power_value;
                if(shield > 100) shield = 100;
                Console.WriteLine($"Shield: {shield}");
            }
            power_pickups++;
        }
    }
}