using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        public string name;
        public int price;
        public int num;
    }

    public class Tofu : Item
    {
        
        public Tofu()
        {
            name = "두부";
            price = 1000;
            num = 1;
        }
    }

    public class Snack : Item
    {
        
        public Snack() 
        {
            name = "과자";
            price = 2500;
            num = 1;
        }
    }
    public class Carrot : Item
    {
        
        public Carrot()
        {
            name = "당근";
            price = 2000;
            num = 1;
        }
    }
    public class Meat : Item
    {
        
        public Meat()
        {
            name = "고기";
            price = 5000;
            num = 1;
        }
    }

    public class Drink : Item
    {
        
        public Drink()
        {
            name = "음료수";
            price = 1000;
            num = 1;
        }
    }
    public class Onion : Item
    {
        
        public Onion()
        {
            name = "양파";
            price = 1500;
            num = 1;
        }
    }
    public class Fish : Item
    {
        
        public Fish()
        {
            name = "생선";
            price = 4000;
            num = 1;
        }
    }
}
