using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    internal class Inventory
    {
        private decimal _money;
        private List<Item> _items;

        public decimal Money { get { return _money; } set { _money = value; } } 
        public List<Item> Items { get { return _items; } }

        public Inventory(decimal money, List<Item> items) 
        {
            _money = money;
            _items = items;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public bool RemoveItem(string itemName) 
        {
            Item? itemToDelete = _items.Find(x => x.Name == itemName);
            if(itemToDelete == null) return false;
            _items.Remove(itemToDelete);
            return true;
        }
    }
}
