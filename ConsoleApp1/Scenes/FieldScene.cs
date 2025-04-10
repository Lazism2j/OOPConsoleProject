using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class FieldScene : Scene
    {
        protected string[] mapData;
        protected Map Map;
        public bool field = true;
        protected List<GameObject> gameObjects;

        // 씬 그리기
        public override void Render()
        {
            Map.Print();
            foreach (GameObject obj in gameObjects)
            {
                obj.Print();
            }
            Game.Player.Print();
        }
        // 입력 결과
        public override void Update()
        {
            Game.Player.Adtion(input);
        }
        // 씬 변경
        public override void Next()
        {
            foreach (GameObject obj in gameObjects)
            {
                if (Game.Player.Pos == obj.Pos)
                {
                    obj.Interact(Game.Player);

                }
            }

        }
        // FieldScene 사이를 움직일 때 체력 감소
        // 체력이 0이 되면 GameOver
        public override void Exit(bool IsField)
        {
            if (IsField)
            {
                Game.Player.Hp--;
            }

            if (Game.Player.Hp == 0)
            {
                Game.gameOver = true;
            }
            
        }


    }
}
