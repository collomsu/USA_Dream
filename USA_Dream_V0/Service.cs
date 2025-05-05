using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Service
    {
        private string _name;
        private decimal _price;
        private List<Statistic> _statsModifier;

        public Service(string name, decimal price)
        {
            this._name = name;
            this._price = price;
            this._statsModifier = new List<Statistic>();
        }

        public Service(string name, decimal price, List<Statistic> statsModifier) : this(name, price)
        {
            this._statsModifier = statsModifier;
        }

        public string Name
        {
            get => _name;
        }

        public decimal Price
        {
            get => _price;
        }

        public List<Statistic> StatsModifier
        {
            get => _statsModifier;
        }

        public void AddStatModifier(Statistic statistic)
        {
            _statsModifier.Add(statistic);
        }

        public bool DeleteStatModifier(Statistic statistic)
        {
            return _statsModifier.Remove(statistic);
        }
    }
}
