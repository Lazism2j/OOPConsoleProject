using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class Mart : FieldScene
    {
        public Mart()
        {
            name = "Mart";
            field = true;
            mapData = new string[]
            {
                "#############",
                "#           #",
                "#           #",
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
            gameObjects.Add(new Place("FrontMart", ConsoleColor.Blue, '@', new Position(1, 4)));
            gameObjects.Add(new Place("MeatAndFish", ConsoleColor.Yellow, '▼', new Position(6, 1)));
            gameObjects.Add(new Place("Vegetable", ConsoleColor.Yellow, '▼', new Position(3, 7)));
            gameObjects.Add(new Place("Refrigerator", ConsoleColor.Yellow, '▼', new Position(11, 5)));


        }


        public override void Enter()
        {
            if (Game.prvScene.name == "FrontMart")
            {
                Game.Player.Pos = new Position(1, 4);
            }
            
            Game.Player.map = Map.map;

            
        }

        public override void Exit(bool IsField)
        {
            // 매장을 나갈 때 바구니의 물건을 가방으로 옮기고
            // 그 값 만큼 돈을 차감
            if (IsField)
            { 
                int convenPrice;
                Game.Player.basket.AllPrice(out convenPrice);

                if (convenPrice <= Game.Player.money)
                {
                    Game.Player.money -= convenPrice;

                    Game.Player.BuyItems(Game.Player.basket);

                }
                
                Game.Player.basket.inventory.Clear();

                // FieldScene 사이를 움직일 때 체력 감소
                if (IsField)
                {
                    Game.Player.Hp--;
                }

            }
        }
    }
}

