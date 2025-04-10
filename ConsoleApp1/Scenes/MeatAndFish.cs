using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class MeatAndFish : Scene
    {
        public MeatAndFish()
        {
            name = "MeatAndFish";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("고기와 생선들을 팔고 있다.");
            Console.WriteLine("바구니에 담을 물건을 고르세요.");
            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine($"1. 고기 : {new Meat().price}원");
            Console.WriteLine($"2. 생선 : {new Fish().price}원");
            
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
                    Game.Player.basket.AddItem(new Meat());
                    break;
                case ConsoleKey.D2:
                    Game.Player.basket.AddItem(new Fish());
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
                    Game.ChangeScene("MeatAndFish");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("MeatAndFish");
                    break;
                default:
                    break;

            }
        }
    }
}
