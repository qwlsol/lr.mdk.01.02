using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private List<Product> data_ = new List<Product>();

        public ProductsModel()
        {
            data_.Add(new Product { Name = "Кроссовки детские «Звёздочка» экокожа", Category = "Детская обувь",
                Count = 20, Price = 2190, Supplier = "Малыш-Спорт", 
                Parts = "Верх — экокожа (полиуретан на хлопковой основе), подкладка — хлопок 100%, подошва — ПВХ" });
            data_.Add(new Product { Name = "Кроссовки детские «Звёздочка» экокожа", Category = "Детская обувь", Count = 20, 
                Price = 2190, Supplier = "Топ-Топ",
                Parts = "Верх — экокожа (микрофибра), подкладка — текстиль сетчатый (полиэстер), подошва — термопластичная резина (ТЭП)", ImagePath = "../../../Images/IMG_KB_164811.png"
            });
            data_.Add(new Product { Name = "Кроссовки детские «Радуга» экокожа перфорированная", Category = "Детская обувь", Count = 20, 
                Price = 2190, Supplier = "Лапушка", 
                Parts = "Верх — экокожа перфорированная, вставки — нейлон, стелька — ортопедическая с латексной подушкой, подошва — ЭВА" });
            


        }

        public List<Product> Load()
        {
            return data_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }
    }
}
