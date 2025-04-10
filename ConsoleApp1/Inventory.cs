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
        
        public Stack<string> stack;

        public Inventory()
        {
            inventory = new List<Item>();
        }

        public void AddItem(Item newItem)
        {
            if (inventory.Count > 0) 
            {
                for(int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i].name == newItem.name)
                    {
                        inventory[i].num = inventory[i].num + newItem.num;
                        break;
                    }
                    
                    if (i == inventory.Count - 1 )
                    {
                        inventory.Add(newItem);
                        break;
                    }
                }
            }
            else
            {
                inventory.Add(newItem);
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
            if (inventory.Count > 0)
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i].name} {inventory[i].num}개");
                }
            }

        }

        public int AllPrice(out int allPrice)
        {
            allPrice = 0;
            foreach (Item item in inventory)
            {
                allPrice += item.price * item.num;
            }


            return allPrice;
        }

       

        public bool Find(string product)
        {
            bool found = false;
            foreach (Item item in inventory)
            {
                found = item.name == product;
                if (found) 
                {
                    break;
                }
                
            }
            return found;
        }

            
        
    }
}
