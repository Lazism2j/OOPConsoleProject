using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FrontHome : Scene
    {
        public string[] mapData;
        public Map FHMap;
       
        private List<GameObject> gameObjects;

        public FrontHome()
        {
            mapData = new string[]
            {
                "##########",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "#        #",
                "##########"

            };

            MapBuilder FHMapBuilder = new MapBuilder();
            FHMapBuilder.SetMap(mapData);
            
            FHMap = FHMapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Start", ConsoleColor.Blue, '@', new Position(4, 6)));

            Game.Player.Pos = new Position(4, 6);
            Game.Player.map = FHMap.map;
        }



        

        // 씬 그리기
        public override void Render()
        {
            FHMap.Print();
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
