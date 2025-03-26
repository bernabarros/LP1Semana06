using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int num_enemy = int.Parse(args[0]);
            Enemy [] enemies = new Enemy [num_enemy];

            for(int i = 0; i < num_enemy; i++)
            {
                Console.Write($"Nome do inimigo: ");
                enemies[i] = new Enemy();
            }
            for(int j = 0; j < num_enemy; j++)
            {
                Console.WriteLine($"{enemies[j].GetName()} "+ 
                $"{enemies[j].GetHealth()} {enemies[j].GetShield()}");
            }
        }
    }
}
