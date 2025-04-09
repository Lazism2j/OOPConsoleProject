using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class GameObject : IInteractable
    {
        private ConsoleColor Color = ConsoleColor.White;
        private char symbol = '*';
        public Position Pos;

        public GameObject(ConsoleColor Color, char symbol, Position Pos)
        {
            this.Color = Color;
            this.symbol = symbol;
            this.Pos = Pos;
        }

        public void Print()
        {
            Console.SetCursorPosition(Pos.x, Pos.y);
            Console.ForegroundColor = Color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);

    }
}
