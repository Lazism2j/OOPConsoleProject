using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Scenes;

namespace ConsoleApp1
{
    class PlayGround : FieldScene
    {
        
        public PlayGround()
        {
            name = "PlayGround";
            field = true;
            mapData = new string[]
            {
                "############",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "#          #",
                "############"

            };

            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.SetMap(mapData);

            Map = mapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontHome", ConsoleColor.Blue, '@', new Position(10, 3)));


        }

        public override void Enter()
        {
            if (Game.prvScene.name == "FrontHome")
            {
                Game.Player.Pos = new Position(10, 3);

                Game.Player.map = Map.map;

                
            }

            // 이전 씬도 필드 이면 플레이어 체력 감소
            if (Game.prvScene.field)
            {
                Game.Player.Hp--;
            }


        }
    }
}


