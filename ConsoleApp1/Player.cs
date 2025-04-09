﻿using System;
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
        public Position NextPos;
        public bool[,] map;
        public void Print()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();

            Console.SetCursorPosition( 0, map.GetLength(0) + 1);
            Console.WriteLine($"체력 : {HP}  남은 돈 : {Money}");
        }

        public void Move(ConsoleKey input)
        {
            NextPos = Pos;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    NextPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    NextPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    NextPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    NextPos.x++;
                    break;
            }
            if (map[NextPos.y, NextPos.x] == true)
            {
                Pos = NextPos;
            }
        }
    }
}
