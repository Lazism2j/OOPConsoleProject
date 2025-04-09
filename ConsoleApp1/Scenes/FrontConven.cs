using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class FrontConvene : FieldScene
    {
        public FrontConvene()
        {
            name = "FrontConven";

            mapData = new string[]
            {
                "##########",
                "#        #",
                "#        #",
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

            Map = FHMapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontHome", ConsoleColor.Blue, '@', new Position(1, 7)));
            //gameObjects.Add(new Place("PlayGround", ConsoleColor.Blue, '@', new Position(1, 3)));



        }


        public override void Enter()
        {
            if (Game.prvSceneName == "FrontHome")
            {
                Game.Player.Pos = new Position(1, 7);
            }
            else if (Game.prvSceneName == "PlayGround")
            {
                Game.Player.Pos = new Position(1, 3);
            }
            Game.Player.map = Map.map;
        }
    }
}
