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
        private Level [] level;
    
        public Level(int room_num,)
        {
            level = new Level [room_num];
            level = Toughness.;
        }
        public Level SetEnemyInRoom(int room_num,Enemy enemy)
        {
            level[room_num] = enemy;
            return level[room_num];
        }

        public Toughness GetToughness()
        {
            return difficulty_set;
        }
        public int GetNumRooms()
        {
            return num_room;
        }
        
        public PrintEnemies()
        {
        }

        public static implicit operator Level(Enemy v)
        {
            throw new NotImplementedException();
        }
    } 
}