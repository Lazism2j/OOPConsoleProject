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
            gameObjects.Add(new Place("FrontConven", ConsoleColor.Blue, '@', new Position(1, 5)));
            gameObjects.Add(new Place("ConvenStand", ConsoleColor.Yellow, '▼', new Position(8, 3)));



        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontConven")
            {
                Game.Player.Pos = new Position(1, 5);
            }

            Game.Player.map = Map.map;

            
        }

        public override void Exit(bool IsField)
        {
            if (IsField)
            { 
                int convenPrice;
                Game.Player.basket.AllPrice(out convenPrice);

                if (convenPrice <= Game.Player.money)
                {
                    Game.Player.money -= convenPrice;

                    Game.Player.BuyItems(Game.Player.basket);

                }
                else
                {
                    //Console.SetCursorPosition(20, 0);
                    //Console.WriteLine("돈이 부족하여 결 제하지 못했습니다.");

                }
                Game.Player.basket.inventory.Clear();

                if (IsField)
                {
                    Game.Player.Hp--;
                }

            }
        }
    }
}
