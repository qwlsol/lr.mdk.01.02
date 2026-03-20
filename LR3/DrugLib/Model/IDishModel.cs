using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrugLib.Model
{
    public interface IDishModel
    {
        Dictionary<string, List<Dish>> LoadData();
        void AddOrderItem(string dishName, int quantity);
        Dictionary<string, int> GetOrderItems();
        void ClearOrder();
        /*new Dish("Цезарь с курицей", 450, "Классический салат Цезарь с куриным филе",
                    "Куриное филе, салат Романо, пармезан, соус Цезарь",
                    Path.Combine(Application.StartupPath, "Images", "cesar.jpg"), "Закуски"),

                new Dish("Греческий салат", 380, "Свежий салат по-гречески с фетой",
                    "Помидоры, огурцы, перец, оливки, сыр фета",
                    Path.Combine(Application.StartupPath, "Images", "greek.jpg"), "Закуски"),

                new Dish("Борщ", 320, "Украинский борщ с пампушками",
                    "Свекла, капуста, картофель, мясо, сметана",
                    Path.Combine(Application.StartupPath, "Images", "borsch.jpg"), "Горячее"),

                new Dish("Стейк Рибай", 1200, "Сочный стейк из мраморной говядины",
                    "Говядина, розмарин, чеснок, сливочное масло",
                    Path.Combine(Application.StartupPath, "Images", "steak.jpg"), "Горячее")
            };*/
}
}
