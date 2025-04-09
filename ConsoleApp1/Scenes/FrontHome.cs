using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Scenes;
//using ConsoleApp1.Scenes;

namespace ConsoleApp1
{
    public class FrontHome : FieldScene
    {
        //public string[] mapData;
        //public Map Map;
       
        //private List<GameObject> gameObjects;

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
            
            Map = FHMapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Start", ConsoleColor.Blue, '@', new Position(4, 6)));
            gameObjects.Add(new Place("PlayGround", ConsoleColor.Blue, '@', new Position(1, 3)));


            Game.Player.Pos = new Position(4, 6);
            Game.Player.map = Map.map;
        }

    }
}
