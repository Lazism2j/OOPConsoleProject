using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class FrontMart : FieldScene
    {
        public FrontMart()
        {
            name = "FrontMart";
            field = true;
            mapData = new string[]
            {
                "#############",
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
            gameObjects.Add(new Place("FrontConven", ConsoleColor.Blue, '@', new Position(4, 5)));
            gameObjects.Add(new Place("Mart", ConsoleColor.Blue, '@', new Position(11, 2)));



        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontConven")
            {
                Game.Player.Pos = new Position(4, 5);
            }
            else if (Game.prvScene.name == "Mart")
            {
                Game.Player.Pos = new Position(11, 2);
            }
            Game.Player.map = Map.map;

            
        }
    }
}
