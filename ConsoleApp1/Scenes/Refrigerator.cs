using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class Refrigerator : Scene
    {
        public Refrigerator()
        {
            name = "Refrigerator";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("냉장고에 물건들이 있다.");
            Console.WriteLine("바구니에 담을 물건을 고르세요.");
            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine($"1. 두부 : {new Tofu().price}원");
            Console.WriteLine($"2. 음료수 : {new Drink().price}원");

            Console.SetCursorPosition(0, 7);
            Console.WriteLine("바구니안의 물건");
            Game.Player.basket.Print();
        }
        // 입력 결과
        public override void Update()
        {
            switch (input)
            {

                case ConsoleKey.D1:
                    Game.Player.basket.AddItem(new Tofu());
                    break;
                case ConsoleKey.D2:
                    Game.Player.basket.AddItem(new Drink());
                    break;

            }
        }
        // 씬 변경
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D0:
                    Game.ChangeScene("Mart");
                    break;
                case ConsoleKey.D1:
                    Game.ChangeScene("Refrigerator");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Refrigerator");
                    break;
                default:
                    break;

            }
        }
    }
}
