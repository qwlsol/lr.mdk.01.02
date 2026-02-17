using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary
{
    public class Pizza
    {
        private string name_;
        private double price_;

        public Pizza(string name, double price)
        {
            name_ = name;
            price_ = price;
        }
        public string Name
        {
            get { return name_; }
        }
        public string Price
        {
            get { return price_.ToString(); }
        }
        public double GetPrice
        {
            get { return price_; }
        }
    }
    public class PizzeriaService
    {
        private Dictionary<string, List<Pizza>> pizza_ = new Dictionary<string, List<Pizza>>();
        public PizzeriaService()
        {
        }
        public bool AddPizzeria(string name, List<Pizza> menu)
        {
            if (name == null || name == "")
            {
                return false;
            }
            if(pizza_.ContainsKey(name))
            {
                return false;
            }
            pizza_.Add(name, menu);
            return true;
        }
        public bool RemovePizzeria(string name) 
        {
            if(name == null || name == "")
            {
                return false;
            }
            if (pizza_.ContainsKey(name))
            {
                return false;
            }
            pizza_.Remove(name);
            return true;
        }
        public bool AddPizza(string pizzeriaName, Pizza pizza)
        {
            if(pizzeriaName == null || pizzeriaName == "")
            { 
                return false;
            }
            if (pizza == null)
            {
                return false;
            }
            if (pizza_.ContainsKey(pizzeriaName))
            {
                return false;
            }
            pizza_[pizzeriaName].Add(pizza);
            return true;
        }
    }

}
