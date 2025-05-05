using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Item
    {
        private string _name;
        private string _description;
        private decimal _price;
        private Action _action;

        public Item(string name, string description, decimal price,Action action)
        {
            this._name = name;
            this._description = description;
            this._price = price;
            this._action = action;
        }

        public string Name
        {
            get { return _name; }
        }
        public string Description
        {
            get { return _description; }
        }
        public decimal Price
        {
            get { return _price; }
        }
        public Action Action
        {
            get { return _action; }
        }


    }
}
