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

            MapBuilder PGMapBuilder = new MapBuilder();
            PGMapBuilder.SetMap(mapData);

            Map = PGMapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontHome", ConsoleColor.Blue, '@', new Position(10, 3)));

            Game.Player.Pos = new Position(4, 6);
            Game.Player.map = Map.map;
        }





        
    }
}


