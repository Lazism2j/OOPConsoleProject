using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class Home : Scene
    {
        public Home()
        {
            name = "Home";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("집에 돌아왔다.");
            Console.WriteLine();

            Console.WriteLine("0. 다시 출발한다.");
            Console.WriteLine("1. 가방을 보여준다.");
        }
        // 입력 결과
        public override void Update()
        {
            switch (input) 
            {
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    if (Game.Player.bag.Find("당근") && 
                        Game.Player.bag.Find("고기") &&
                        Game.Player.bag.Find("두부"))
                    {    
                        Game.gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("물건이 부족합니다.");
                        Console.WriteLine("계속하려면 아무키나 누르세요.");
                    }

                    break;  
                default:
                    break;
            }
            
        }
        // 씬 변경 혹은 게임오버
        public override void Next()
        {
            
            switch (input)
            {
                case ConsoleKey.D0:
                    Game.ChangeScene("FrontHome");
                    break;
                case ConsoleKey.D1:
                    Game.ChangeScene("Home");
                    break;    
            }
        }

        public override void Enter()
        {
            if (Game.gameOver) 
            {
                Game.gameOver = true; 
            
            }
        }
    }
}
