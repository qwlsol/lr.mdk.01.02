using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary
{
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
            if (pizza_.ContainsKey(name))
            {
                return false;
            }
            pizza_.Add(name, menu);
            return true;
        }
        public bool RemovePizzeria(string name)
        {
            if (name == null || name == "")
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
            if (pizzeriaName == null || pizzeriaName == "")
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
        public bool RemovePizzaFromPizzeria(string pizzeriaName, string pizzaName)
        {
            if (pizzeriaName == null || pizzeriaName == "" || pizzaName == null || pizzaName == "")
            {
                return false;
            }
            if (pizza_.ContainsKey(pizzeriaName))
            {
                return false;
            }
            Pizza pizzaToRemove = null;
            foreach (var pizza in pizza_[pizzeriaName]) 
            {
                if (pizza.Name.ToLower()== pizzaName.ToLower())
                {
                    pizzaToRemove = pizza;
                    break;
                }
            }
            if (pizzaToRemove != null) 
            {
                pizza_[pizzeriaName].Remove(pizzaToRemove);
                return true;
            }
            return false;
        }
        public string FindPizza(string pizzaName)
        {
            if (pizzaName == null || pizzaName == "")
            {
                return "Вы не указали название пиццы";
            }
            string result = "\nПицца '" + pizzaName + "'найдена в:\n";
        }
    }
}
