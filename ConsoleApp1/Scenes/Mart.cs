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

            // 이전 씬도 필드 이면 플레이어 체력 감소
            if (Game.prvScene.field)
            {
                Game.Player.Hp--;
            }
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
                    // Console.WriteLine("돈이 부족하여 결제하지 못했습니다.");

                }
                Game.Player.basket.inventory.Clear();
            }
        }
    }
}

