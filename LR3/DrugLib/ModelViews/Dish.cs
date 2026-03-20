using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public class Dish
    {
        private string name_;
        private int price_;
        private string description_;
        private string ingredients_;
        private string imagePath_;
        private string group_;

        public Dish(string name, string price, string description, string ingredients, string imagePath, string group)
        {
            name_ = name;
            if (!int.TryParse(price, out price_))
            {
                price_ = 0;
            }
            description_ = description;
            ingredients_ = ingredients;
            imagePath_ = imagePath;
            group_ = group;
        }

        public string Name
        {
            get { return name_; }
        }
        public string Price
        {
            get { return price_.ToString("0"); }
        }
        public string Description
        {
            get { return description_; }
        }
        public string Ingredients
        {
            get { return ingredients_; }
        }
        public string Group
        {
            get { return group_; }
        }
        public string ImagePath
        {
            get { return imagePath_; }
        }
    }
}
