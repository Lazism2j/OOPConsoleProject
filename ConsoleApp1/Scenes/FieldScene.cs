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
            Game.Player.Move(input);
        }
        // 씬 변경 혹은 게임오버
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
    }
}
