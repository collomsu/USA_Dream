using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Action
    {
        private string _name;
        private string _description;
        private List<Statistic> _statisticsModifier = new List<Statistic>();

        public Action(string name, string description , params Statistic[] statistics)
        {
            this._name = name;
            this._description = description;
            foreach (var statistic in statistics) 
            { 
                this._statisticsModifier.Add(statistic);
            }
        }
        
        public string Name
        {
            get { return _name; }
        }
        public string Description
        {
            get { return this._description; }
        }
        public List<Statistic> StatisticModifier
        {
            get { return (this._statisticsModifier); }
        }
        public void AddStatistic(Statistic statistic) 
        {
            this.StatisticModifier.Add(statistic);
        }
        public bool RemoveStatistic(string name)
        {
            Statistic? statToDelete = _statisticsModifier.Find(s => s.Name == name);
            if (statToDelete == null) return false;
            _statisticsModifier.Remove(statToDelete);
            return true;
        }

        public bool DoAction(ref Human person)
        {
            List<Statistic> statisticsPerson = person.Statistics;
            foreach (Statistic stat in this._statisticsModifier)
            {
                try
                {
                    Statistic statisticPerson = statisticsPerson.Find(s => s.Name == stat.Name);

                    statisticPerson.Value += stat.Value;
                    if (statisticPerson.Value < 0) { statisticPerson.Value = 0; }
                    else if (statisticPerson.Value > 100) { statisticPerson.Value = 100; }
                }
                catch 
                {
                    return false;
                }
            }
            return true;
        }

    }
}
