using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TitleScene : Scene
    {
        public TitleScene()
        {
            name = "Title";
            
        }
        // 씬 그리기
        public override void Render()
        {
            Console.WriteLine("┌-------------------┐");
            Console.WriteLine("┃    7살 서율이의   ┃");
            Console.WriteLine("┃   심부름 도전기   ┃");
            Console.WriteLine("└-------------------┘");
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
            Game.ChangeScene("Start");
        }

        public override void Enter()
        {
            Game.Player.Hp = 10;
            Game.Player.money = 10000;
        }
    }
}
