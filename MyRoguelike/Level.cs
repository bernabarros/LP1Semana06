using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Level
    {
        private int num_room;
        private Toughness difficulty_set;
        private Toughness chosen_dif;
        static Toughness level_dif;
        private Level [] level;
    
        public Level(int room_num, Toughness difficulty_set)
        {
            level = new Level [room_num];
            chosen_dif = difficulty_set;
        }
        static Level()
        {
            level_dif = Toughness.Nightmare;
        }
        public Level SetEnemyInRoom(int room_num,Enemy enemy)
        {
            level[room_num] = enemy;
            return level[room_num];
        }

        public Toughness GetToughness()
        {
            return level_dif;
        }
        public int GetNumRooms()
        {
            return num_room;
        }
        
        public PrintEnemies()
        {
            
        }
    } 
}