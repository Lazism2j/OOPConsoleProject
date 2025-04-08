using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StartScene : Scene
    {
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("생의 첫 심부름을 나간다.");
            Console.WriteLine("사야 할 물건 : 두부, 당근, 고기");
            Console.WriteLine("남은 돈은 용돈으로 사용 가능하다.");
            Console.WriteLine();

            Console.WriteLine("계속하려면 아무키나 누르세요");
        }
        // 입력 결과
        public override void Update()
        {

        }
        // 씬 변경 혹은 게임오버
        public override void Next()
        {
            Game.ChangeScene("Title");
        }
    }
}
