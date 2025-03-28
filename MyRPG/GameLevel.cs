using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Room[] rooms;
        private Hardness level;
        public GameLevel(int r, Hardness level)
        {
            rooms = new Room[r];
            for (int i = 0; i < r; i++)
            {
                rooms[i] = new Room();
            }
            this.level = level;
        }

        public void SetEnemyInRoom(int index, Enemy inimigo)
        {
            rooms[index].Enemy = inimigo;
        }
        public class Room
        {
            public Enemy Enemy { get; set; }

            public Room(Enemy enemy = null)
            {
                Enemy = enemy;
            }
        }

        public Hardness GetHardness()
        {
            return level;
        }

        public int GetNumRooms()
        {
            int roomn = rooms.Count();
            return roomn;
        }

        public int GetNumEnemies()
        {
            int num = 0;
            for (int i = 0; i < rooms.Count(); i++)
            {
                if (rooms[i].Enemy != null)
                {
                    num++;
                }
            }
            return num;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < rooms.Count(); i++)
            {
                if (rooms[i].Enemy != null)
                {
                    Console.WriteLine($"Room {i.ToRoman()}: {rooms[i].Enemy.GetName()}");
                }
            }
        }
    }
}
