using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    class ConvenStand : Scene
    {
        public ConvenStand()
        {
            name = "ConvenStand";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("여러가지 물건들을 팔고 있다.");
            Console.WriteLine("바구니에 담을 물건을 고르세요.");
            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine($"1. 과자 : {new Snack().price}원");
            Console.WriteLine($"2. 음료수 : {new Drink().price}원");
            Console.WriteLine($"3. 두부 : {new Tofu().price}원");
            
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("바구니안의 물건");
            Game.Player.basket.Print();
        }
        // 입력 결과
        public override void Update()
        {
            switch (input)
            {
                
                case ConsoleKey.D1:
                    Game.Player.basket.AddItem(new Snack());
                    break;
                case ConsoleKey.D2:
                    Game.Player.basket.AddItem(new Drink());
                    break;
                case ConsoleKey.D3:
                    Game.Player.basket.AddItem(new Tofu());
                    break;
                
            }
        }
        // 씬 변경 혹은 게임오버
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D0:
                    Game.ChangeScene("ConvenStore");
                    break;
                case ConsoleKey.D1:
                    Game.ChangeScene("ConvenStand");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("ConvenStand"); 
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("ConvenStand");
                    break;
                default:
                    break;

            }
        }
    }
}
