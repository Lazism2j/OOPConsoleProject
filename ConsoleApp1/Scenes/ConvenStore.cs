using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Scenes
{
    class ConvenStore : FieldScene
    {
        public ConvenStore()
        {
            name = "ConvenStore";

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

            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.SetMap(mapData);

            Map = mapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontConven", ConsoleColor.Blue, '@', new Position(1, 5)));
            //gameObjects.Add(new Place("PlayGround", ConsoleColor.Blue, '@', new Position(1, 3)));



        }


        public override void Enter()
        {
            if (Game.prvSceneName == "FrontConven")
            {
                Game.Player.Pos = new Position(1, 5);
            }
            
            Game.Player.map = Map.map;
        }
    }
}
