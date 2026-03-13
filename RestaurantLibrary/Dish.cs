using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Dish
    {
        private string name_;
        private int price_;
        private string description_;
        private string ingredients_;
        private string photo_;
        private string group_;

        /// <summary>
        /// Конструктор блюда
        /// </summary>
        public Dish(string name, int price, string description, string ingredients, string photo, string group)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название блюда не может быть пустым", nameof(name));

            if (price <= 0)
                throw new ArgumentException("Цена должна быть положительным числом", nameof(price));

            name_ = name;
            price_ = price;
            description_ = description ?? string.Empty;
            ingredients_ = ingredients ?? string.Empty;
            photo_ = photo ?? string.Empty;
            group_ = group ?? string.Empty;
        }

        public string Name => name_;
        public int Price => price_;
        public string Description => description_;
        public string Ingredients => ingredients_;
        public string Photo => photo_;
        public string Group => group_;

        /// <summary>
        /// Получить информацию о блюде
        /// </summary>
        public string GetInfo()
        {
            return $"Название: {name_}\n" +
                   $"Категория: {group_}\n" +
                   $"Цена: {price_} руб.\n" +
                   $"Описание: {description_}\n" +
                   $"Ингредиенты: {ingredients_}";
        }

        /// <summary>
        /// Переопределение ToString для отображения в списках
        /// </summary>
        public override string ToString()
        {
            return $"{name_} ({price_} руб.)";
        }
    }
}

