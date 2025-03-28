using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace MyRoguelike
{
    public class Level
    {
        private int num_room;
        private Toughness chosen_dif;
        private string [] room_set;
    
        public Level(int num_room, Toughness chosen_dif)
        {
            this.num_room = num_room;
            this.chosen_dif = chosen_dif;
            room_set = new string [num_room];
        }
        public string[] SetEnemyInRoom(int room_num, Enemy enemy)
        {
            this.room_set[room_num] = enemy.GetName();
            return room_set;
        }

        public Toughness GetToughness()
        {
            return chosen_dif;
        }
        public int GetNumRooms()
        {
            return num_room;
        }
        
        public void PrintEnemies()
        {
            for(int i = 0;i < this.num_room; i++)
            {
                if(this.room_set[i] == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{i.ToOrdinalWords()} room = {room_set[i]}".Transform(To.TitleCase));
                }
            }
        }

        public int GetNumEnemies()
        {
            int num_enemy = 0;
            for(int i = 0;i < this.num_room; i++)
            {
                if(this.room_set[i] == null)
                {
                    continue;
                }
                else
                {
                    num_enemy++;
                }
            }
            return num_enemy;
        }
    } 
}