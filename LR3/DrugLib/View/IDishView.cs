using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib
{
    public interface IDishView
    {
        void ShowCategories(List<string> categories);
        void ShowDishInCategory(List<Dish> dish);
        void ShowDishDetails(Dish dish);
        void ShowOrderSummary(Dictionary<string, int> orderItems);
        string GetSelectedCategory();
        Dish GetSelectedDish();
        int GetOrderQuantity();
    }
}
