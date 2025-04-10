using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class Mart : FieldScene
    {
        public Mart()
        {
            name = "Mart";
            field = true;
            mapData = new string[]
            {
                "#############",
                "#           #",
                "#           #",
                "#           #",
                "#           #",
                "#           #",
                "#           #",
                "#           #",
                "#############"

            };

            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.SetMap(mapData);

            Map = mapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontMart", ConsoleColor.Blue, '@', new Position(1, 4)));
            //gameObjects.Add(new Place("Mart", ConsoleColor.Blue, '@', new Position(11, 2)));



        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontMart")
            {
                Game.Player.Pos = new Position(1, 4);
            }
            
            Game.Player.map = Map.map;

            // 이전 씬도 필드 이면 플레이어 체력 감소
            if (Game.prvScene.field)
            {
                Game.Player.Hp--;
            }
        }
    }
}

