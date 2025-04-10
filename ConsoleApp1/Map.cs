using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Map
    {
        public string[] data;
        public bool[,] map;

        public void Print()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }


    }
    // 빌더를 통해 string배열을 받아 맵 그리기
    public class MapBuilder
    {
        public string[] data;
        public bool[,] map;

        public MapBuilder()
        {
            data = new string[]
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
            map = new bool[data.Length, data[0].Length];
            

        }

        public Map Build()
        {
            Map map = new Map();
            map.data = data;
            map.map = new bool[data.Length, data[0].Length];
            for (int y = 0; y < data.Length; y++)
            {
                for (int x = 0; x < data[y].Length; x++)
                {
                    map.map[y, x] = data[y][x] == '#' ? false : true;
                }
            }

            return map;
        }

        public MapBuilder SetMap(string[] data)
        {
            this.data = data;

            return this;
        }
    }

}
