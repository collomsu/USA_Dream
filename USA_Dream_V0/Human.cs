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
            //TODO voir comment on definit les stats/items de base
        }

        public string Name { get { return _name; } }
        public Inventory Inventory { get { return _inventory; } }
        public List<Statistic> Statistics { get {  return _statistics; } }
    }
}
