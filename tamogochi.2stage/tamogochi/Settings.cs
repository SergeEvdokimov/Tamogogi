using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamogochi
{
    public enum Actions
    {
        Eat,
        Sleep,
        Game,
        Clear
    }
    class Settings
    {
        public static scale eat;
        public static scale sleep;
        public static scale happy;
        public static scale clear;
        public static scale HP;
        public static int speed;
        public static bool is_game_over;
        public static int default_dif;
        public static int dif;
        public static int add;
        public static MyQueue commands;
        public static int queue_speed;
        public static MyStack Stack_commands;
        public static int Stack_speed;
        public Settings()
        {
            eat = new scale(100);
            sleep = new scale(100);
            happy = new scale(100);
            clear = new scale(100);
            HP = new scale(100);
            speed = 2;
            default_dif = 1;
            is_game_over = false;
            dif = 5;
            add = 15;
            commands = new MyQueue();
            queue_speed = 16;
            Stack_commands = new MyStack();
            Stack_speed = 16;
        }
    }
}
