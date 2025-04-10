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
                "#        #",
                "#        #",
                "##########"

            };

            MapBuilder mapBuilder = new MapBuilder();
            mapBuilder.SetMap(mapData);

            Map = mapBuilder.Build();

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FrontHome", ConsoleColor.Blue, '@', new Position(1, 7)));
            gameObjects.Add(new Place("ConvenStore", ConsoleColor.Blue, '@', new Position(8, 4)));
            gameObjects.Add(new Place("FrontMart", ConsoleColor.Blue, '@', new Position(4, 1)));



        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontHome")
            {
                Game.Player.Pos = new Position(1, 7);
            }
            else if (Game.prvScene.name == "ConvenStore")
            {
                Game.Player.Pos = new Position(8, 4);
            }
            else if (Game.prvScene.name == "FrontMart")
            {
                Game.Player.Pos = new Position(4, 1);
            }
            Game.Player.map = Map.map;

            
        }
    }
}
