﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA_Dream_V0
{
    public class Business
    {
        private string _name;
        private string _description;
        private List<Service> _services;
        private List<Item> _items;

        public Business(string name, string description) 
        { 
            this._name = name;
            this._description = description;
            this._services = new List<Service>();
            this._items = new List<Item>();
        }

        public Business(string name, string description, List<Service> services) : this(name, description) 
        {
            this._services = services;
        }

        public Business(string name, string description, List<Item> items) : this(name, description)
        {
            this._items = items;
        }

        public Business(string name, string description, List<Service> services, List<Item> items) : this(name, description)
        {
            this._services = services;
            this._items = items;
        }

        public string Name
        {
            get => _name;
        }

        public string Description
        {
            get => _description;
        }

        public List<Service> Services
        {
            get => _services;
        }

        public List<Item> Items
        {
            get => _items;
        }

        public void AddService(Service service)
        {
            _services.Add(service);
        }

        public bool DeleteService(string serviceName)
        {
            Service? ServiceToDelete = _services.Find(x => x.Name == serviceName);
            if (ServiceToDelete == null) return false;
            _services.Remove(ServiceToDelete);
            return true;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public bool DeleteItem(string itemName)
        {
            Item? itemToDelete = _items.Find(x => x.Name == itemName);
            if (itemToDelete == null) return false;
            _items.Remove(itemToDelete);
            return true;
        }
    }
}
