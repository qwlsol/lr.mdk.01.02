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
}
