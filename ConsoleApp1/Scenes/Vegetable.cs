using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class Vegetable : Scene
    {
        public Vegetable()
        {
            name = "Vegetable";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("여러 야채들이 진열되어 있다.");
            Console.WriteLine("바구니에 담을 물건을 고르세요.");
            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine($"1. 당근 : {new Carrot().price}원");
            Console.WriteLine($"2. 양파 : {new Onion().price}원");

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
                    Game.Player.basket.AddItem(new Carrot());
                    break;
                case ConsoleKey.D2:
                    Game.Player.basket.AddItem(new Onion());
                    break;

            }
        }
        // 씬 변경 혹은 게임오버
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D0:
                    Game.ChangeScene("Mart");
                    break;
                case ConsoleKey.D1:
                    Game.ChangeScene("Vegetable");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Vegetable");
                    break;
                default:
                    break;

            }
        }
    }
}
