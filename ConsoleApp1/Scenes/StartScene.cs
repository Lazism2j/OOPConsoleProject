using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StartScene : Scene
    {
        
        public StartScene() 
        {
            name = "Start";
            field = false;
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("생의 첫 심부름을 나간다.");
            Console.WriteLine("사야 할 물건 : 두부, 당근, 고기");
            Console.WriteLine("남은 돈은 용돈으로 사용 가능하다.");
            Console.WriteLine();

            Console.WriteLine("0. 타이틀로 돌아가기");
            Console.WriteLine("1. 심부름 출발하기");
        }
        // 입력 결과
        public override void Update()
        {

        }
        // 씬 변경
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("FrontHome");
                    break;
                case ConsoleKey.D0:
                    Game.ChangeScene("Title");
                    break;
                default:
                    break;

            }
            
        }

       

    }
}
