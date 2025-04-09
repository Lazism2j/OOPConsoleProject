using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory
    {
        public List<Item> inventory;

        public Inventory()
        {
            inventory = new List<Item>();
        }

        public void AddItem(Item newItem)
        {

            foreach (Item have in inventory)
            {
                if (have.name == newItem.name)
                {
                    have.num = have.num + newItem.num;
                }
                else
                {
                    inventory.Add(newItem);
                }
            }

        }
        public void RemoveItem(Item item)
        {

            inventory.Remove(item);

        }
        public void RemoveItem(int num)
        {
            if (inventory[num].num > 1)
            {
                inventory[num].num--;
            }
            else
            {
                inventory.RemoveAt(num);
            }

        }

        public void Print()
        {
            Console.WriteLine("바구니안의 물건");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].name} {inventory[i].num}개");
            }

        }
    }
}
