using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        private int HP;
        private int Money;

        public Position Pos;

        public void Print()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    Pos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    Pos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    Pos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    Pos.x++;
                    break;


            }
        }
    }
}
