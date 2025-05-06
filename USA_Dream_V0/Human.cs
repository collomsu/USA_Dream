using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Human
    {
        private string _name;
        private Inventory _inventory;
        private List<Statistic> _statistics;

        public Human(string name) 
        { 
            _name = name;
            _inventory = new Inventory(0, new List<Item>());
            _statistics = new List<Statistic>();
        }

        public Human(string name, Inventory inventory) : this(name)
        {
            _inventory = inventory;
        }

        public Human(string name, List<Statistic> statistics) : this(name)
        {
            _statistics = statistics;
        }

        public Human(string name, Inventory inventory, List<Statistic> statistics) : this(name, inventory)
        {
            _statistics = statistics;
        }


        public string Name { get { return _name; } }
        public Inventory Inventory { get { return _inventory; } }
        public List<Statistic> Statistics { get {  return _statistics; } }

        public void AddStatistic(Statistic statistic) 
        { 
            _statistics.Add(statistic); 
        }

        public bool ModifyStatistic(string name, int value) 
        { 
            Statistic? statToModify= _statistics.Find(s => s.Name == name);
            if (statToModify == null) return false;
            statToModify.Value += value;
            return true;
        }

        public bool RemoveStatistic(string name) 
        {
            Statistic? statToDelete = _statistics.Find(s => s.Name == name);
            if (statToDelete == null) return false;
            _statistics.Remove(statToDelete);
            return true;
        }

        public void AddItem(Item item) 
        { 
            _inventory.AddItem(item);
        }

        public bool RemoveItem(string name) 
        { 
            return _inventory.RemoveItem(name);
        }

        public void ModifyMoney(decimal value)
        {
            _inventory.Money += value;
        }
    }
}
