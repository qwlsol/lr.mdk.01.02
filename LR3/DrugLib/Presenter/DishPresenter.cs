using DrugLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugLib.Presenter
{
    public class DishPresenter
    {
        private IDishModel model_;
        private IDishView view_;

        public DishPresenter(IDishModel model, IDishView view)
        {
            model_ = model;
            view_ = view;

            var allData = model_.LoadData();
            view_.ShowCategories(allData.Keys.ToList());
        }

        public void CategorySelected()
        {
            string category = view_.GetSelectedCategory();
            if (!string.IsNullOrEmpty(category))
            {
                var allData = model_.LoadData();
                if (allData.ContainsKey(category))
                {
                    view_.ShowDishInCategory(allData[category]);
                }
            }
        }

        public void DishSelected()
        {
            Dish dish = view_.GetSelectedDish();
            if (dish != null)
            {
                view_.ShowDishDetails(dish);
            }
        }

        public void AddToOrder()
        {
            Dish dish = view_.GetSelectedDish();
            int quantity = view_.GetOrderQuantity();

            if (dish != null && quantity > 0)
            {
                model_.AddOrderItem(dish.Name, quantity);
                view_.ShowOrderSummary(model_.GetOrderItems());
            }
        }
    }
}
