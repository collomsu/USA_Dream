using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Statistic
    {
        private string _name;
        private int _value;

        public string Name { get { return _name; } set { _name = value; } }
        public int Valeur { get { return _value; } set { _value = value; } }

        public Statistic(string name, int value) 
        {
            _name = name;
            _value= value;
        }
    }
}
