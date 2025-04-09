using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Scenes;

namespace ConsoleApp1
{
    public class FrontHome : FieldScene
    {
        
        public FrontHome()
        {
            name = "FrontHome";
            field = true;

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

            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.SetMap(mapData);
            
            Map = mapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Start", ConsoleColor.Blue, '@', new Position(4, 6)));
            gameObjects.Add(new Place("PlayGround", ConsoleColor.Blue, '@', new Position(1, 3)));
            gameObjects.Add(new Place("FrontConven", ConsoleColor.Blue, '@', new Position(8, 2)));



        }


        public override void Enter()
        {
            if(Game.prvScene.name == "Start")
            {
                Game.Player.Pos = new Position(4, 6);
            }
            else if(Game.prvScene.name == "PlayGround") 
            {
                Game.Player.Pos = new Position(1, 3);
            }
            else if (Game.prvScene.name == "FrontConven")
            {
                Game.Player.Pos = new Position(8, 2);
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
