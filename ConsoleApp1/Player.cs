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
        public int Hp { get { return HP; } set { HP = value; } }
        public int money { get { return Money; }set { Money = value; } }

        public Inventory bag;
        public Inventory basket;

        

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
            Console.WriteLine($"현재 위치 : {Game.nowSceneName} \n체력 : {HP}  남은 돈 : {Money}원");
            Console.WriteLine("가방 안의 물건");
            bag.Print();
            
        }

        public void Adtion(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    Move(input); 
                    break;
                
                 
                default:
                    break;
            }
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


        // Player의 바구니에서 가방으로 옮기는 작업
        public void BuyItems(Inventory basket)
        {
            for (int i = 0; i < basket.inventory.Count; i++) 
            {
                bag.AddItem(basket.inventory[i]);           
            }
        }


    }
}
