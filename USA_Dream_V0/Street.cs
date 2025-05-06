using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Street
    {
        private string _name;
        private string _description;
        private List<Business> _businesss;

        public Street(string name, string description)
        {
            this._name = name;
            this._description = description;
            this._businesss = new List<Business>();
        }

        public Street(string name, string description, List<Business> businesss) : this(name, description)
        {
            _businesss = businesss;
        }

        public string Name
        {
            get => _name;
        }

        public string Description
        {
            get => _description;
        }

        public List<Business> Business
        {
            get => _businesss;
        }

        public void AddBusiness(Business business)
        {
            _businesss.Add(business);
        }

        public bool DeleteBusiness(string businessName)
        {
            Business? BusinessToDelete = _businesss.Find(x => x.Name == businessName);
            if (BusinessToDelete == null) return false;
            _businesss.Remove(BusinessToDelete);
            return true;
        }
    }
}
