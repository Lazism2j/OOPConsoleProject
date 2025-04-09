using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        public string name;
        public int price;
        public int num = 1;
    }

    public class Tofu : Item
    {
        public string name = "Tofu";
        public int price = 1000;
        public int num = 1;
    }

    public class Snack : Item
    {
        public string name = "Snack";
        public int price = 2500;
        public int num = 1;
    }
    public class Carrot : Item
    {
        public string name = "Carrot";
        public int price = 2000;
        public int num = 1;
    }
    public class Meat : Item
    {
        public string name = "Meat";
        public int price = 5000;
        public int num = 1;
    }

    public class Drink : Item
    {
        public string name = "Drink";
        public int price = 1000;
        public int num = 1;
    }
    public class Onion : Item
    {
        public string name = "Onion";
        public int price = 1500;
        public int num = 1;
    }
    public class Fish : Item
    {
        public string name = "Fish";
        public int price = 4000;
        public int num = 1;
    }
}
