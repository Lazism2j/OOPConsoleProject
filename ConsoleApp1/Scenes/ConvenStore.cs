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
            gameObjects.Add(new Place("ConvenStand", ConsoleColor.DarkCyan, '@', new Position(8, 3)));

            

        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontConven")
            {
                Game.Player.Pos = new Position(1, 5);
            }
            
            Game.Player.map = Map.map;

            // 이전 씬도 필드 이면 플레이어 체력 감소
            if (Game.prvScene.field)
            {
                Game.Player.Hp--;
            }
        }

        public override void Exit()
        {
            int convenPrice;
            Game.Player.basket.AllPrice(out convenPrice);
            
            if ( convenPrice <= Game.Player.money)
            {
                Game.Player.money -= convenPrice;

                Game.Player.BuyItems(Game.Player.basket);

                Game.Player.basket.inventory.Clear();
                
            }
        }
    }
}
