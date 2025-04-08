using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FrontHome : Scene
    {
        public string[] mapData;
        public Map FHMap;
       
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
            
            FHMap = FHMapBuilder.Build();
        }



        

        // 씬 그리기
        public override void Render()
        {
            FHMap.Print();
        }
        // 입력 결과
        public override void Update()
        {

        }
        // 씬 변경 혹은 게임오버
        public override void Next()
        {
            Game.ChangeScene("FrontHome");
        }
    }
}
